﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace GravityShift
{
    /// <summary>
    /// Represents an object that has rules based on physics
    /// </summary>
    abstract class PhysicsObject : GameObject
    {
        protected PhysicsEnvironment mEnvironment;
        
        //All forces applied to this physicsObject
        private Vector2 mGravityForce = new Vector2(0,0);
        private Vector2 mResistiveForce = new Vector2(1,1);
        private Vector2 mAdditionalForces = new Vector2(0, 0);

        public Vector2 mVelocity = new Vector2(0, 0);

        /// <summary>
        /// Directional force on this object
        /// </summary>
        public Vector2 TotalForce
        {
            get {  return (Vector2.Add(mGravityForce,mAdditionalForces));  }
        }

        /// <summary>
        /// Speed and direction of this object
        /// </summary>
        public Vector2 ObjectVelocity
        {
            get { return mVelocity;  }
            set { mVelocity = value; }
        }

        /// <summary>
        /// Constructs a PhysicsObject; Loads the required info from the content pipeline, and defines its size and location
        /// </summary>
        /// <param name="content">Content pipeline</param>
        /// <param name="spriteBatch">The drawing canvas of the game. Used for collision detection with the level</param>
        /// <param name="name">Name of the physics object so that it can be loaded</param>
        /// <param name="scalingFactors">Factor for the image resource(i.e. half the size would be (.5,.5)</param>
        /// <param name="initialPosition">Position of where this object starts in the level</param>
        public PhysicsObject(ContentManager content, String name, Vector2 scalingFactors, Vector2 initialPosition, ref PhysicsEnvironment environment, float friction,bool isSquare)
            :base(content,name,scalingFactors,initialPosition, friction, isSquare)
        {
            mEnvironment = environment;
            UpdateBoundingBoxes();
        }

        /// <summary>
        /// Adds an additional force to the physics object
        /// </summary>
        /// <param name="force">Force to be added</param>
        public void AddForce(Vector2 force)
        {
            mAdditionalForces = Vector2.Add(mAdditionalForces, force);
        }

        /// <summary>
        /// TEMP METHOD - WILL GIVE THE PLAYER THE ABILITY TO FALL FROM ONE END OF THE SCREEN TO THE OTHER
        /// </summary>
        public void FixForBounds(int width, int height)
        {
            if (mPosition.X < 0) mPosition.X += width;
            if (mPosition.Y < 0) mPosition.Y += height;

            mPosition.X %= width;
            mPosition.Y %= height;
        }

        /// <summary>
        /// Reorient gravity in the given direction
        /// </summary>
        /// <param name="direction">Direction to enforce gravity on</param>
        public void ChangeGravityForceDirection(GravityDirections direction)
        {
            mResistiveForce = new Vector2(1, 1);

            if (direction == GravityDirections.Up || 
                direction == GravityDirections.Down) 
                mResistiveForce.X = mEnvironment.ErosionFactor;
            else 
                mResistiveForce.Y = mEnvironment.ErosionFactor;

            mGravityForce = mEnvironment.GravityForce;
        }

        /// <summary>
        /// Enforces a maximum speed that a force can 
        /// </summary>
        private void EnforceTerminalVelocity()
        {
            if (mVelocity.X > mEnvironment.TerminalSpeed)
                mVelocity.X = mEnvironment.TerminalSpeed;
            if (mVelocity.X < -mEnvironment.TerminalSpeed)
                mVelocity.X = -mEnvironment.TerminalSpeed;
            if (mVelocity.Y > mEnvironment.TerminalSpeed)
                mVelocity.Y = mEnvironment.TerminalSpeed;
            if (mVelocity.Y < -mEnvironment.TerminalSpeed)
                mVelocity.Y = -mEnvironment.TerminalSpeed;
        }

        /// <summary>
        /// Updates the bounding box around this object
        /// </summary>
        private void UpdateBoundingBoxes()
        {
            mBoundingBox = new Rectangle((int)mPosition.X, (int)mPosition.Y,
                (int)mSize.X, (int)mSize.Y);
        }

        /// <summary>
        /// Updates the velocity based on the force
        /// </summary>
        private void UpdateVelocities()
        {
            mVelocity = Vector2.Add(mVelocity, mEnvironment.GravityForce);
            mVelocity = Vector2.Add(mVelocity, mAdditionalForces);

            //Force erosion on the resistive forces(friction/wind resistance)
            ChangeGravityForceDirection(mEnvironment.GravityDirection);
            mVelocity = Vector2.Multiply(mVelocity,mResistiveForce);

            EnforceTerminalVelocity();
        }

        /// <summary>
        /// Update the physics object based on the given gametime
        /// </summary>
        /// <param name="gametime">Current gametime</param>
        public virtual void Update(GameTime gametime)
        {
            UpdateVelocities();
            mPosition = Vector2.Add(mPosition, mVelocity);
            UpdateBoundingBoxes();
        }

        /// <summary>
        /// Returns true if the physics objects are colliding with each other
        /// (only good for 2 boxes) (no circles yet)
        /// TODO - Add pixel perfect collision
        /// </summary>
        /// <param name="otherObject">The other object to test against</param>
        /// <returns>True if they are colliding with each other; False otherwise</returns>
        public virtual bool IsCollidingBoxAndBox(GameObject otherObject)
        {
            return !Equals(otherObject) && mBoundingBox.Intersects(otherObject.mBoundingBox);
        }
        /// <summary>
        /// Returns true if the physics objects are colliding with each other
        /// </summary>
        /// <param name="otherObject">The other object to test against</param>
        /// <returns>True if they are colliding with each other; False otherwise</returns>
        public virtual bool IsCollidingCircleandCircle(GameObject otherObject)
        {
            int radiusA = this.mBoundingBox.Width/2;
            int radiusB = otherObject.mBoundingBox.Width/2;
            Point centerPosA = this.mBoundingBox.Center;
            Point centerPosB = otherObject.mBoundingBox.Center;
            Vector2 centers = new Vector2(centerPosA.X - centerPosB.X, centerPosA.Y - centerPosB.Y);
            return !Equals(otherObject) && (centers.Length()<(radiusA+radiusB));
        }


        /// <summary>
        /// Handles collision for two boxes (this, and other)
        /// </summary>
        /// <param name="otherObject">box to calculate collision on</param>
        public virtual void HandleCollideBoxAndBox(GameObject otherObject)
        {
            if (!IsCollidingBoxAndBox(otherObject))
            {
                return;
            }
            Vector2 colDepth = GetCollitionDepth(otherObject);

            // handle the shallowest collision
            if (Math.Abs(colDepth.X) > Math.Abs(colDepth.Y))
            {
                //Reset Y Velocity to 0
                mVelocity.Y = 0;
                // reduce x velocity for friction
                mVelocity.X *= otherObject.mFriction;
                // place the Y pos just so it is not colliding. 
                mPosition.Y += colDepth.Y;
            }
            else
            {
                //Reset X Velocity to 0
                mVelocity.X = 0;
                // reduce Y velocity for friction
                mVelocity.Y *= otherObject.mFriction;
                // place the X pos just so it is not colliding.
                mPosition.X += colDepth.X;
            }
            UpdateBoundingBoxes();
        }
         /// <summary>
        /// Handles collision for a circle and circle
        /// (Kinda works, very buggy)
        /// </summary>
        /// <param name="otherObject">circle object to do collision on</param>
        public virtual void HandleCollideCircleAndCircle(GameObject otherObject)
        {
            if (!IsCollidingCircleandCircle(otherObject))
            {
                return;
            }
            Point centerA = this.mBoundingBox.Center;
            Point centerB = otherObject.BoundingBox.Center;

            Vector2 colDepth = GetCollitionDepth(otherObject);

            Vector2 centerDiff = new Vector2(centerA.X - centerB.X, centerA.Y - centerB.Y);

            int radiusA = this.mBoundingBox.Width / 2;
            int radiusB = otherObject.mBoundingBox.Width / 2;

            float delta = (radiusA + radiusB) - centerDiff.Length();
            centerDiff.Normalize();
            Vector2 add = Vector2.Multiply(centerDiff, delta);

            //Reset Y Velocity to 0
            mVelocity.Y = otherObject.mFriction;
            // reduce x velocity for friction
            mVelocity.X = otherObject.mFriction;
            // place the Y pos just so it is not colliding. 
            mPosition += add;

            UpdateBoundingBoxes();

        }
        /// <summary>
        /// Handles collision for a circle and box(circle = this)
        /// (Works for Individual blocks, a little buggy when tiling blocks)
        /// </summary>
        /// <param name="otherObject">square object to do collision on</param>
        public virtual void HandleCollideCircleAndBox(GameObject otherObject)
        {
            if (!IsCollidingBoxAndBox(otherObject))
            {
                return;
            }
            float radius = this.mBoundingBox.Width / 2;
            // get points of square
            Point[] p = new Point[4];
            // top left
            p[0] = new Point(otherObject.mBoundingBox.X,otherObject.mBoundingBox.Y);
            // top right
            p[1] = new Point(otherObject.mBoundingBox.X + otherObject.mBoundingBox.Width, p[0].Y);
            // bottom right
            p[2] = new Point(p[1].X, otherObject.mBoundingBox.Y + otherObject.mBoundingBox.Height);
            // bottom left
            p[3] = new Point(p[0].X, p[2].Y);

            Point center = this.BoundingBox.Center;
            // if not going to collide with a corner
            if (((center.X >= p[0].X) && (center.X <= p[1].X)) // top/bottom side
             || ((center.Y >= p[1].Y) && (center.Y <= p[2].Y)))// right/left side
            {
                // then treat like a square /square
                HandleCollideBoxAndBox(otherObject);
            }
            else// going to hit a corner
            {
                // treat like circle/point collision
                Point centerA = this.mBoundingBox.Center;
                Point centerB = new Point();
                if ((center.X < p[0].X) && (center.Y < p[0].Y))// top left corner
                {
                    centerB = p[0];
                }
                else if ((center.X > p[1].X) && (center.Y < p[1].Y))// top right corner
                {
                    centerB = p[1];
                }
                else if ((center.X > p[2].X) && (center.Y > p[2].Y))// bottom right corner
                {
                    centerB = p[2];
                }
                else if ((center.X < p[3].X) && (center.Y > p[3].Y))// bottom left corner
                {
                    centerB = p[3];
                }

                Vector2 centerDiff = new Vector2(centerA.X - centerB.X, centerA.Y - centerB.Y);

                int radiusA = this.mBoundingBox.Width / 2;

                float delta = (radiusA) - centerDiff.Length();
                centerDiff.Normalize();
                Vector2 add = Vector2.Multiply(centerDiff, delta);

                // if you do not do not change mVelocity on a corner collision
                // (do not factor in friction) it gives the appearance of "rolling off" the corner

                // place the Y pos just so it is not colliding. 
                mPosition += add;

                UpdateBoundingBoxes();
            }
        }
        /// <summary>
        /// finds how deep they are intersecting (That is what she said!)
        /// </summary>
        /// <returns>vector decribing depth</returns>
        public Vector2 GetCollitionDepth(GameObject otherObject)
        {
            //Find Center
            int halfHeight1 = this.BoundingBox.Height / 2;
            int halfWidth1 = this.BoundingBox.Width / 2;

            //Calculate Center Position
            Vector2 center1 = new Vector2(this.BoundingBox.Left + halfWidth1, this.BoundingBox.Top + halfHeight1);
            
            //Find Center of otherObject
            int halfHeight2 = otherObject.BoundingBox.Height / 2;
            int halfWidth2 = otherObject.BoundingBox.Width / 2;

            //Calculate Center Position
            Vector2 center2 = new Vector2(otherObject.BoundingBox.Left + halfWidth2, otherObject.BoundingBox.Top + halfHeight2);
            
            //Center distances between both objects
            float distX = center1.X - center2.X;
            float distY = center1.Y - center2.Y;

            //Minimum distance 
            float minDistX = halfWidth1 + halfWidth2;
            float minDistY = halfHeight1 + halfHeight2;

            if (!IsCollidingBoxAndBox(otherObject))
            {
                return Vector2.Zero;
            }

            float depthX, depthY;
            if (distX > 0)
            {
                depthX = minDistX - distX;
            }
            else
            {
                depthX = -minDistX - distX;
            }
            if (distY > 0)
            {
                depthY = minDistY - distY;
            }
            else
            {
                depthY = -minDistY - distY;
            }

            return new Vector2(depthX, depthY);
        }


        /// <summary>
        /// Handles collision for a circle and box(circle = this)
        /// WORKS IN THEORY, NOT IN PRACTICE (DO NOT USE)
        /// </summary>
        /// <param name="otherObject">square object to do collision on</param>
        public virtual void HandleCollidePixelPerfect(GameObject otherObject)
        {
            while (IntersectPixels(this.mBoundingBox, this.mSpriteImageData, otherObject.mBoundingBox, otherObject.mSpriteImageData))
            {
                // keep going back till you are no longer collding
                Vector2 reverse = Vector2.Multiply(mVelocity, -1);
                reverse.Normalize();
                mPosition += reverse;
                mVelocity = Vector2.Zero;
                UpdateBoundingBoxes();
            }
        }

        //IntersectPixels method taken directly from the XNA 2D per pixel collision check. Doesn't need to be changed as far as I can see. 
        /// <summary>
        /// MAY NEED TO BE CHANGED "taken directly from the XNA 2D per pixel collision check."
        /// </summary>
        /// <param name="rectangleA"></param>
        /// <param name="dataA"></param>
        /// <param name="rectangleB"></param>
        /// <param name="dataB"></param>
        /// <returns></returns>
        private bool IntersectPixels(Rectangle rectangleA, Color[] dataA, Rectangle rectangleB, Color[] dataB)
        {
            int top = Math.Max(rectangleA.Top, rectangleB.Top);
            int bottom = Math.Min(rectangleA.Bottom, rectangleB.Bottom);
            int left = Math.Max(rectangleA.Left, rectangleB.Left);
            int right = Math.Min(rectangleA.Right, rectangleB.Right);

            for (int y = top; y < bottom; y++)
            {
                for (int x = left; x < right; x++)
                {
                    Color colorA = dataA[(x - rectangleA.Left) +
                                (y - rectangleA.Top) * rectangleA.Width];
                    Color colorB = dataB[(x - rectangleB.Left) +
                                (y - rectangleB.Top) * rectangleB.Width];

                    if (colorA.A != 0 && colorB.A != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        } 

        public abstract void Kill();
        public abstract override string ToString();
    }
}