using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.Services.Character
{
    static class EquipmentService
    {
       
        public static void Equip(ICharacter character,IEquipable item)
        {
            try
            {
                if(character.Bag.Any(x => x.GetType() == item.GetType() && x.IsEquiped))
                character.Bag.Single(x => x.GetType() == item.GetType() && x.IsEquiped).IsEquiped = false;
                character.Bag.First(x => x.Id == item.Id).IsEquiped = true;
            }
            catch(Exception e)
            {
                //if the item is not found,will inform the client that the item is not found
                //will also send a flag that a possible hack is in the process 
                ExceptionService.RespondToClient(e);
            }

           

        }
        public static void Unequip(ICharacter character, IEquipable item)
        {
            try
            {
                character.Bag.FirstOrDefault(x => x.Id == item.Id).IsEquiped = true;
            }
            catch(Exception e)
            {
                //if the item is not found will inform the client that the item is not found
                //will also send a flag that a possible hack is in the process 
                ExceptionService.RespondToClient(e);
                
            }
        }
        public static void PickUpItem(ICharacter character, IEquipable item)
        {
            
        }
    }
}
