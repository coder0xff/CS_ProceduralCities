using ICities;

namespace ProceduralCities
{

    public class ProceduralCitiesMod: IUserMod
    {

        public string Name 
        {
            get { return "Procedural Cities"; }
        }

        public string Description 
        {
            get { return "Generate cities using algorithms"; }
        }

    }

    // Inherit interfaces and implement your mod logic here
    // You can use as many files and subfolders as you wish to organise your code, as long
    // as it remains located under the Source folder.

}
