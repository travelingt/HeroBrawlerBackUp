#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using FarseerPhysics;
using FarseerPhysics.Common;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;
using FarseerPhysics.Collision.Shapes;
using FarseerPhysics.Controllers;
using FarseerPhysics.Collision;
using FarseerPhysics.Common.PhysicsLogic;
using FarseerPhysics.Dynamics.Contacts;
using FarseerPhysics.Dynamics.Joints;
#endregion


namespace HeroBrawler
{
   ///<summary>
   ///This is the class that all character will be created from, they won't inherit from this instead they will be data that is used to 
   ///skin this class
   ///</summary>

    public class Character
    {
        string name;
        //Drawing Varibles/Graphics Varibles
        Texture2D MainTexture;
        
        //Physics varibles
        Body MainBody;
        Fixture MainFixture;
        PolygonShape PS;
        
        public Character(Vector2 Pos)
        {
            MainBody = new Body(Game1.Instance.world);
            MainBody.BodyType = BodyType.Dynamic;
            Vertices Verts = new Vertices(4);
            Verts.Add(new Vector2(0,0));
            Verts.Add(new Vector2(0,100));
            Verts.Add(new Vector2(100,0));
            Verts.Add(new Vector2(100,100));
            PS = new PolygonShape(Verts, 1);
            MainFixture = MainBody.CreateFixture(PS);
            MainTexture = Game1.Instance.Content.Load<Texture2D>("CancelButton");
            MainBody.Position = Pos;
          // PS = new PolygonShape()
        }
        //
        public void Update()
        {
         //   KeyboardState KS = Keyboard.GetState();

           // MainBody.LinearVelocity = new Vector2();
        
        }

        public void Draw()
        {
           
            Game1.Instance.spriteBatch.Draw(MainTexture, //Texture
                new Rectangle((int)MainBody.Position.X, (int)MainBody.Position.Y, 100,100),//Position in world, and size
                Color.White);//Color, this should just be white, unless this becomes a Dungeon crawler, at which point AWESOME
        }
    }
}
