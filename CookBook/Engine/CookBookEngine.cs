using CookBook.Data;
using CookBook.Engine;
using System.Xml;

namespace CookBook
{
    public static class CookBookEngine
    {
        public static void Start()
        {
            Recipes mainCollectionRecipes = new Recipes();

            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\recipes.xml");
            XmlNode rootNode = doc.DocumentElement;
            mainCollectionRecipes.LoadFromXML(rootNode);
            // var queryByProduct = mainCollectionRecipes.ByProduct("yoghurt");

            StartScreen startScreen = new StartScreen(mainCollectionRecipes);
            startScreen.ShowDialog();
        }



        public static void DisplayRecipes(Recipes collection)
        {

        }
    }
}
