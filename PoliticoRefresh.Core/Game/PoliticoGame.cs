#region Using Statements
using System;
using System.IO; 
using System.Text.Json; 
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Text.Json.Serialization;
#endregion

namespace PoliticoRefresh
{
    public class PoliticoGame
    {
        private GraphicsDevice graphicsDevice; 
        private Grid grid;
        private ChronoCycle cycle;
        private List<Person> People;

        public PoliticoGame(GraphicsDevice graphicsDevice)
        {
            this.graphicsDevice = graphicsDevice;
            Camera.LoadTransform();
            grid = new Grid();
            cycle = new ChronoCycle();
        }

        public void LoadContent(ContentManager Content)
        {
            cycle.LoadContent();
            grid.LoadContent(Content);
            string jsonPath = Path.Combine(Content.RootDirectory, "People.json");
            string jsonString = File.ReadAllText(jsonPath); 
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
            People = JsonSerializer.Deserialize<List<Person>>(jsonString, options);
            foreach (Person p in People)
                Console.WriteLine(p.SayHello()); 
        }

        public void Update(GameTime gametime)
        {
            Camera.Update(gametime); 
            grid.Update(gametime);
            cycle.Update(gametime);
        }

        public void Draw(SpriteBatch sbatch)
        {
            sbatch.Begin(SpriteSortMode.FrontToBack, transformMatrix: Camera.LoadTransform(graphicsDevice, 1f));
            cycle.Draw(sbatch); 
            sbatch.End();  
            sbatch.Begin(SpriteSortMode.FrontToBack, transformMatrix: Camera.Transform);
            grid.Draw(sbatch); 
            sbatch.End(); 
        }
    }
}