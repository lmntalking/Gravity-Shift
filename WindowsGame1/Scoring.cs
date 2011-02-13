﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using System.Text;

namespace GravityShift
{
    class Scoring
    {
        #region Member Variables

        /* Spritefont */
        private SpriteFont mKootenay;
        private SpriteFont mQuartz;

        private Rectangle mScreenRect;

        ContentManager mContent;

        IControlScheme mControls;

        /* Equivalent of stars */
        private static Texture2D[] mNumApples;
        private const int POSSIBLE_APPLES = 3;

        /* Keep track of the level */
        private static int[,] mLevel;
        private static int[,] mScore;

        private Texture2D[] mSelItems;
        private Texture2D[] mUnselItems;
        private Texture2D[] mItems;

        private int mCurrent;

        private const int NUM_OPTIONS = 4;

        #endregion

        #region Art

        private Texture2D mNextLevelSel;
        private Texture2D mNextLevelUnsel;
        private Texture2D mSelectLevelSel;
        private Texture2D mSelectLevelUnsel;
        private Texture2D mMainMenuSel;
        private Texture2D mMainMenuUnsel;
        private Texture2D mRestartSel;
        private Texture2D mRestartUnsel;

        private Texture2D mTitle;

        #endregion

        #region Getters and Setters

        /* Getter/Setter for the apples variable */
//        public static int[] Apples
//        {
//            get { return num_apples; }
//            set { num_apples = value; }
//        }

        /* Getter/Setter for the level variable */
        public static int[,] Level
        {
            get { return mLevel; }
            set { mLevel = value; }
        }

        /* Getter/Setter for the score variable */
        public static int[,] Score
        {
            get { return mScore; }
            set { mScore = value; }
        }

        #endregion

        public Scoring(IControlScheme controls) 
        {
            mControls = controls;
        }

        /*
         * Load
         *
         * Similar to a loadContent function. This function loads and 
         * initializes the variable and art used in the class.
         *
         * ContentManager content: the Content file used in the game.
         */
        public void Load(ContentManager content, GraphicsDevice graphics)
        {
            mContent = content;
            mKootenay = content.Load<SpriteFont>("Fonts/Kootenay");
            mQuartz = content.Load<SpriteFont>("Fonts/QuartzLarge");

            mCurrent = 0;

            mScreenRect = graphics.Viewport.TitleSafeArea;

            mSelItems = new Texture2D[NUM_OPTIONS];
            mUnselItems = new Texture2D[NUM_OPTIONS];
            mItems = new Texture2D[NUM_OPTIONS];

            mNextLevelSel = content.Load<Texture2D>("Images/Menu/Score/NextLevelSelected");
            mNextLevelUnsel = content.Load<Texture2D>("Images/Menu/Score/NextLevelUnselected");

            mSelectLevelSel = content.Load<Texture2D>("Images/Menu/SelectLevelSelected");
            mSelectLevelUnsel = content.Load<Texture2D>("Images/Menu/SelectLevelUnselected");

            mMainMenuSel = content.Load<Texture2D>("Images/Menu/MainMenuSelected");
            mMainMenuUnsel = content.Load<Texture2D>("Images/Menu/MainMenuUnselected");

            mRestartUnsel = content.Load<Texture2D>("Images/Menu/Score/RestartUnselected");
            mRestartSel = content.Load<Texture2D>("Images/Menu/Score/RestartSelected");

            mTitle = content.Load<Texture2D>("Images/Menu/Mr_Gravity");

            mSelItems[0] = mNextLevelSel;
            mSelItems[1] = mRestartSel;
            mSelItems[2] = mSelectLevelSel;
            mSelItems[3] = mMainMenuSel;

            mUnselItems[0] = mNextLevelUnsel;
            mUnselItems[1] = mRestartUnsel;
            mUnselItems[2] = mSelectLevelUnsel;
            mUnselItems[3] = mMainMenuUnsel;

            mItems[0] = mNextLevelSel;
            mItems[1] = mRestartUnsel;
            mItems[2] = mSelectLevelUnsel;
            mItems[3] = mMainMenuUnsel;
        }

        /*
         * Update
         *
         * Updates the menu depending on what the user has selected.
         * It will handle the title, options, load and all other menu 
         * screens
         *
         * GameTime gameTime: The current game time variable
         */
        public void Update(GameTime gameTime, ref GameStates gameState, ref Level level)
        {
            int []scores = GetRank((int)GravityShift.Level.TIMER, level.IdealTime, (int)GravityShift.Level.mNumCollected, level.CollectableCount, GravityShift.Level.mDeaths);
            level.TimerStar = scores[0];
            level.CollectionStar = scores[1];
            level.DeathStar = scores[2];
            
            /* If the user hits up */
            if (mControls.isUpPressed(false))
            {
                /* If we are not on the first element already */
                if (mCurrent > 0)
                {
                    GameSound.menuSound_rollover.Play(GameSound.volume, 0.0f, 0.0f);
                    /* Decrement current and change the images */
                    mCurrent--;
                    for (int i = 0; i < NUM_OPTIONS; i++)
                        mItems[i] = mUnselItems[i];
                    mItems[mCurrent] = mSelItems[mCurrent];
                }
            }
            /* If the user hits the down button */
            if (mControls.isDownPressed(false))
            {
                /* If we are on the last element in the menu */
                if (mCurrent < NUM_OPTIONS - 1)
                {
                    GameSound.menuSound_rollover.Play(GameSound.volume, 0.0f, 0.0f);
                    /* Increment current and update graphics */
                    mCurrent++;
                    for (int i = 0; i < NUM_OPTIONS; i++)
                        mItems[i] = mUnselItems[i];
                    mItems[mCurrent] = mSelItems[mCurrent];
                }
            }

            /* If the user selects one of the menu items */
            if (mControls.isAPressed(false) || mControls.isStartPressed(false))
            {
                GravityShift.Level.TIMER = 0;
                GameSound.menuSound_select.Play(GameSound.volume, 0.0f, 0.0f);

                /* Next Level */
                if (mCurrent == 0)
                {
                    /*Back To Level Selection*/
                    gameState = GameStates.Next_Level;

                    mCurrent = 0;

                    mItems[0] = mNextLevelSel;
                    mItems[1] = mRestartUnsel;
                    mItems[2] = mSelectLevelUnsel;
                    mItems[3] = mMainMenuUnsel;
                    
                }
                /* Restart Level */
                else if (mCurrent == 1)
                {
                    
                    /* Start the game*/
                    gameState = GameStates.In_Game;
                    level.Reset();
                    level.Load(mContent);
                    mCurrent = 0;

                    mItems[0] = mNextLevelSel;
                    mItems[1] = mRestartUnsel;
                    mItems[2] = mSelectLevelUnsel;
                    mItems[3] = mMainMenuUnsel;
                }

                /* Level Select */
                else if (mCurrent == 2)
                {
                    /*Back To Level Selection*/
                    gameState = GameStates.Level_Selection;

                    mCurrent = 0;

                    mItems[0] = mNextLevelSel;
                    mItems[1] = mRestartUnsel;
                    mItems[2] = mSelectLevelUnsel;
                    mItems[3] = mMainMenuUnsel;
                }

                /* Main Menu */
                else if (mCurrent == 3)
                {
                    gameState = GameStates.Main_Menu;

                    mCurrent = 0;

                    mItems[0] = mNextLevelSel;
                    mItems[1] = mRestartUnsel;
                    mItems[2] = mSelectLevelUnsel;
                    mItems[3] = mMainMenuUnsel;
                }
            }
        }
        /* GetRank
         * 
         * int time: time to complete level
         * 
         * int timeGoal: goal time
         * 
         * int collect: collectables received
         * 
         * int collectGoal: Total collectables in level
         * 
         * int deathTotal: number of deaths
         * 
         * return int[] (number of stars-- 0=Bad, 1=Okay, 2=Good, 3=Perfect): [Time, Collectables, Death]
         */
        public int[] GetRank(int time, int timeGoal, int collect, int collectGoal, int deathTotal)
        {
            int[] result = new int[3];

            /* TIME -- 100%+, <120%, <140%, >140% */
            if (time < timeGoal) { result[0] = 3; }
            else if (((double) time / (double) timeGoal) > 1.2) { result[0] = 2; }
            else if (((double) time / (double) timeGoal) > 1.4) { result[0] = 1; }
            else { result[0] = 0; }

            /* COLLECTABLES -- 100%, >80%, >60%, <60% */
            if (collect == collectGoal) { result[1] = 3; }
            else if (((double) collect / (double) collectGoal) > 0.8) { result[1] = 2; }
            else if (((double) collect / (double) collectGoal) > 0.6) { result[1] = 1; }
            else { result[1] = 0; }

            /* DEATHS -- 0, 1, 2-3, >3 */
            if (deathTotal == 0) { result[2] = 3; }
            else if (deathTotal == 1) { result[2] = 2; }
            else if (deathTotal <= 3) { result[2] = 1; }
            else { result[2] = 0; }

            return result;
        }

        /*
         * Draw
         *
         * This function will draw the current menu
         *
         * SpriteBatch spriteBatch: The current sprite batch used to draw
         * 
         * GraphicsDeviceManager graphics: The current graphics manager
         */
        public void Draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics, Matrix scale)
        {
            spriteBatch.Begin(SpriteSortMode.Immediate,
                BlendState.AlphaBlend,
                SamplerState.LinearClamp,
                DepthStencilState.None,
                RasterizerState.CullCounterClockwise,
                null,
                scale);

            //TODO: CHANGE TO DYNAMIC PLACING

            spriteBatch.Draw(mTitle, new Vector2(mScreenRect.Left + (mScreenRect.Width - mTitle.Width) / 2, mScreenRect.Top), Color.White);

            spriteBatch.DrawString(mQuartz, "Time:", new Vector2(mScreenRect.Left + (mScreenRect.Width / 5) , mScreenRect.Top + mScreenRect.Height / 4), Color.White);
            spriteBatch.DrawString(mQuartz, "Time:", new Vector2(mScreenRect.Left + (mScreenRect.Width / 5) + 1, mScreenRect.Top + mScreenRect.Height / 4 + 1), Color.SteelBlue);
            spriteBatch.DrawString(mQuartz, (int)GravityShift.Level.TIMER + " Seconds", new Vector2(mScreenRect.Left + (mScreenRect.Width / 3 + 100), mScreenRect.Top + mScreenRect.Height / 4), Color.White);

            spriteBatch.DrawString(mQuartz, "Collected:", new Vector2(mScreenRect.Left + (mScreenRect.Width / 5), mScreenRect.Top + mScreenRect.Height / 4 + 50), Color.White);
            spriteBatch.DrawString(mQuartz, "Collected:", new Vector2(mScreenRect.Left + (mScreenRect.Width / 5) + 1, mScreenRect.Top + mScreenRect.Height / 4 + 51), Color.SteelBlue);
            spriteBatch.DrawString(mQuartz, (int)GravityShift.Level.mNumCollected + " / " + GravityShift.Level.mNumCollectable, new Vector2(mScreenRect.Left + (mScreenRect.Width / 3 + 100), mScreenRect.Top + mScreenRect.Height / 4 + 50), Color.White);

            spriteBatch.DrawString(mQuartz, "Deaths:", new Vector2(mScreenRect.Left + (mScreenRect.Width / 5), mScreenRect.Top + mScreenRect.Height / 4 + 100), Color.White);
            spriteBatch.DrawString(mQuartz, "Deaths:", new Vector2(mScreenRect.Left + (mScreenRect.Width / 5) + 1, mScreenRect.Top + mScreenRect.Height / 4 + 101), Color.SteelBlue);
            spriteBatch.DrawString(mQuartz, "" + (int)GravityShift.Level.mDeaths, new Vector2(mScreenRect.Left + (mScreenRect.Width / 3 + 100), mScreenRect.Top + mScreenRect.Height / 4 + 100), Color.White);

//            spriteBatch.Draw(mItems[0], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Right - (mItems[0].Width), 
//                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[0].Height - 250, 
//                mItems[0].Width, mItems[0].Height), Color.White);
//            spriteBatch.Draw(mItems[1], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Right - (mItems[1].Width) - (mItems[1].Width / 4),
//                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[1].Height - 175,
//                mItems[1].Width, mItems[1].Height), Color.White);
//            spriteBatch.Draw(mItems[2], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Right - (mItems[2].Width),
//                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[2].Height - 100,
//                mItems[2].Width, mItems[2].Height), Color.White);
//            spriteBatch.Draw(mItems[3], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Right - (mItems[3].Width) - (mItems[1].Width / 8),
//                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[3].Height - 25,
//                mItems[3].Width, mItems[3].Height), Color.White);
            spriteBatch.Draw(mItems[0], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Center.X - (mItems[0].Width / 2) + (mItems[0].Width/3),
                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[0].Height - 250,
                mItems[0].Width, mItems[0].Height), Color.White);
            spriteBatch.Draw(mItems[1], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Center.X - (mItems[1].Width / 2) + (mItems[0].Width/3),
                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[1].Height - 175,
                mItems[1].Width, mItems[1].Height), Color.White);
            spriteBatch.Draw(mItems[2], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Center.X - (mItems[2].Width / 2) + (mItems[0].Width/3),
                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[2].Height - 100,
                mItems[2].Width, mItems[2].Height), Color.White);
            spriteBatch.Draw(mItems[3], new Rectangle(graphics.GraphicsDevice.Viewport.TitleSafeArea.Center.X - (mItems[3].Width / 2) + (mItems[0].Width/3),
                graphics.GraphicsDevice.Viewport.TitleSafeArea.Bottom - mItems[3].Height - 25,
                mItems[3].Width, mItems[3].Height), Color.White);

            spriteBatch.End();
        }
    }
}
