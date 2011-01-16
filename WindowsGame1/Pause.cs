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
using System.Xml.Linq;
using GravityShift.Import_Code;
using System.IO;

namespace GravityShift
{
    class Pause
    {
        #region Member Variables

        /* Spritefont */
        private SpriteFont mKootenay;

        private Texture2D[] mSelItems;
        private Texture2D[] mUnselItems;
        private Texture2D[] mItems;

        IControlScheme mControls;

        private int mCurrent;

        ContentManager mContent;

        private const int NUM_OPTIONS = 3;

        #endregion

        #region Art

        private Texture2D mPauseTitle;

        private Texture2D mResumeSel;
        private Texture2D mResumeUnsel;
        private Texture2D mSelectLevelSel;
        private Texture2D mSelectLevelUnsel;
        private Texture2D mMainMenuSel;
        private Texture2D mMainMenuUnsel;

        #endregion

        public Pause(IControlScheme controlScheme)
        {
            mControls = controlScheme;
        }

        public void Load(ContentManager content)
        {
            mContent = content;

            mKootenay = content.Load<SpriteFont>("fonts/Kootenay");

            mPauseTitle = content.Load<Texture2D>("menu/paused");

            mCurrent = 0;

            mSelItems = new Texture2D[NUM_OPTIONS];
            mUnselItems = new Texture2D[NUM_OPTIONS];
            mItems = new Texture2D[NUM_OPTIONS];

            mResumeSel = content.Load<Texture2D>("menu/ResumeSelected");
            mResumeUnsel = content.Load<Texture2D>("menu/ResumeUnselected");
            mSelectLevelSel = content.Load<Texture2D>("menu/SelectLevelSelected");
            mSelectLevelUnsel = content.Load<Texture2D>("menu/SelectLevelUnselected");
            mMainMenuSel = content.Load<Texture2D>("menu/MainMenuSelected");
            mMainMenuUnsel = content.Load<Texture2D>("menu/MainMenuUnselected");

            mSelItems[0] = mResumeSel;
            mSelItems[1] = mSelectLevelSel;
            mSelItems[2] = mMainMenuSel;

            mUnselItems[0] = mResumeUnsel;
            mUnselItems[1] = mSelectLevelUnsel;
            mUnselItems[2] = mMainMenuUnsel;

            mItems[0] = mResumeSel;
            mItems[1] = mSelectLevelUnsel;
            mItems[2] = mMainMenuUnsel;
        }

        public void Update(GameTime gameTime, ref GameStates gameState, ref Level level)
        {
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
            /* If the user selects a menu item */
            if (mControls.isAPressed(false))
            {
                 GameSound.menuSound_select.Play(GameSound.volume, 0.0f, 0.0f);
                /* Resume Game */
                 if (mCurrent == 0)
                     gameState = GameStates.In_Game;
                 /* Select Level */
                 else if (mCurrent == 1)
                 {
                     gameState = GameStates.Level_Selection;
                     level.Reset();
                     mCurrent = 0;
                 }
                 /* Main Menu */
                 else if (mCurrent == 2)
                 {
                     gameState = GameStates.Main_Menu;
                     level.Reset();
                     mCurrent = 0;
                 }

                 mItems[0] = mResumeSel;
                 mItems[1] = mSelectLevelUnsel;
                 mItems[2] = mMainMenuUnsel;
            }
        }

        public void Draw(SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            spriteBatch.Begin();

            /* Draw the pause title */
            spriteBatch.Draw(mPauseTitle, new Vector2(180.0f, 50.0f), Color.White);

            /* Draw the pause options */
            spriteBatch.Draw(mItems[0], new Vector2(500.0f, 425.0f), Color.White);
            spriteBatch.Draw(mItems[1], new Vector2(500.0f, 500.0f), Color.White);
            spriteBatch.Draw(mItems[2], new Vector2(500.0f, 580.0f), Color.White);

            spriteBatch.End();
        }
    }
}
