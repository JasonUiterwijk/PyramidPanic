using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //Fields, de velden van deze klas
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public PyramidPanic()
        {
            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

      
        protected override void Initialize()
        {
            //maakt de muis zichtbaar in het canvas
            IsMouseVisible = true;

            //Veranderd de titel van de canvas
            this.Window.Title = "Pyramid Panic";
            
            //veranderd de breedte van de canvas
            this.graphics.PreferredBackBufferWidth = 640;

            //veranderd de hoogte van de canvas
            this.graphics.PreferredBackBufferHeight = 480;

            //past de veranderingen betreffende het canvas toe
            this.graphics.ApplyChanges();
            base.Initialize();
        }

        
        protected override void LoadContent()
        {
           
            this.spriteBatch = new SpriteBatch(GraphicsDevice);

            
        }

        
        protected override void UnloadContent()
        {
           
        }

        
        protected override void Update(GameTime gameTime)
        {
           //wanner de gamepad back toets of de escape toets wordt ingedrukt dan
            //stopt het spel
            if ( (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
                (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();

           

            base.Update(gameTime);
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Purple);

            

            base.Draw(gameTime);
        }
    }
}
