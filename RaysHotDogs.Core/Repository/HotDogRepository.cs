using RaysHotDogs.Core.Model;
using System.Collections.Generic;
using System.Linq;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>
        {
            new HotDogGroup
            {
                HotDogGroupId = 1,
                Title = "Meat lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>
                {
                    new HotDog
                    {
                        HotDogId = 1,
                        Name = "Regular Hot Dog 1",
                        ShortDescription = "Menchego smelly chees danish fontina. Hard chees...",
                        ImagePath = "hotDog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Baked bun", "Gourmet sausage"},
                        Price = 10,
                        IsFavorite = false
                    },
                    new HotDog
                    {
                        HotDogId = 2,
                        Name = "Not regular Hot Dog 2",
                        ShortDescription = "Menchego smelly chees danish fontina. Hard chees...",
                        ImagePath = "hotDog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Baked bun", "Gourmet sausage"},
                        Price = 10,
                        IsFavorite = false
                    }
                },

            },
            new HotDogGroup
            {
                HotDogGroupId = 1,
                Title = "Vegan freaks",
                ImagePath = "",
                HotDogs = new List<HotDog>
                {
                    new HotDog
                    {
                        HotDogId = 3,
                        Name = "Regular Hot Dog 3",
                        ShortDescription = "Menchego smelly chees danish fontina. Hard chees...",
                        ImagePath = "hotDog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Baked bun", "Gourmet sausage"},
                        Price = 8,
                        IsFavorite = false
                    },
                    new HotDog
                    {
                        HotDogId = 4,
                        Name = "NOT regular Hot Dog 4",
                        ShortDescription = "Hard chees...",
                        ImagePath = "hotDog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string> {"Baked bun", "Gourmet sausage"},
                        Price = 10,
                        IsFavorite = false
                    }
                }

            }
        };

        public List<HotDog> GetAllHotDogs()
        {
            var hotDogs = from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs

                select hotDog;
            return hotDogs.ToList();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            var hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == hotDogId
                select hotDog;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDog()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            var group = hotDogGroups.FirstOrDefault(h => h.HotDogGroupId == hotDogGroupId);

            return @group?.HotDogs;
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            var hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.IsFavorite
                select hotDog;

            return hotDogs.ToList();
        }

    }
}
