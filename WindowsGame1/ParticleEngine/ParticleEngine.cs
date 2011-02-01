﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GravityShift
{
    public class ParticleEngine
    {
        private Random random;
        public Vector2 EmitterLocation { get; set; }
        private List<Particle> particles;
        private List<Texture2D> textures;
        public int colorScheme;

        public ParticleEngine(List<Texture2D> textures, Vector2 location, int scheme)
        {
            EmitterLocation = location;
            this.textures = textures;
            this.particles = new List<Particle>();
            random = new Random();
            colorScheme = scheme;
        }

        // Set variables. This is the guts of the whole system.
        private Particle GenerateNewParticle()
        {
            Texture2D texture = textures[random.Next(textures.Count)];
            Vector2 position = EmitterLocation;
            
            // Set velocity randomly from [-1.0, 1.0] is both x and y.
            Vector2 velocity = new Vector2(
                    1f * (float)(random.NextDouble() * 2 - 1),
                    1f * (float)(random.NextDouble() * 2 - 1));
            
            // Generate random spin
            float angle = 0;
            float angularVelocity = 0.1f * (float)(random.NextDouble() * 2 - 1);
            
            // Random RGB color values
            Color color = new Color();
            //Color color = new Color(
            //        (float)random.NextDouble(),
            //        (float)random.NextDouble(),
            //        (float)random.NextDouble());

            int whichColor = random.Next(3);
            // Color scheme 1
            switch (whichColor)
            {
                case 0:
                    color = new Color(247, 255, 0);
                    break;
                case 1:
                    color = new Color(250, 255, 76);
                    break;
                case 2:
                    color = new Color(239, 255, 143);
                    break;
                default:
                    break;
            }

            // Random size
            float size = (float)random.NextDouble();
            
            // Every particle lives for at least 10 updates but as many as 25 (time-to-live)
            int ttl = 20 + random.Next(20);

            return new Particle(texture, position, velocity, angle, angularVelocity, color, size, ttl);
        }

        public void Update(int particleCount)
        {
            // Add particleCount particles each update (based on velocity from Level.cs)
            for (int i = 0; i < particleCount; i++)
                particles.Add(GenerateNewParticle());

            // Loop through all particles and call their dependent Update functions. Remove dead particles
            for (int particle = 0; particle < particles.Count; particle++)
            {
                particles[particle].Update();
                if (particles[particle].TTL <= 0)
                {
                    particles.RemoveAt(particle);
                    particle--;
                }
            }
        }

        // Call the particle's dependent draw function
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int index = 0; index < particles.Count; index++)
                particles[index].Draw(spriteBatch);
        }

    }
}