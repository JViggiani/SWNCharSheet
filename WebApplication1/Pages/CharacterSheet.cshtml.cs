using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
//this is the model
namespace WebApplication1.Pages
{
    public class CharacterSheetModel : PageModel
    {
        //Character overview
        public string Name { get; set; }
        public string Class { get; set; }
        public string Background { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Faction { get; set; }
        public string Homeworld { get; set; }

        //Core stats
        public short Level { get; set; }
        public short CurrentHP { get; set; }
        public short MaxHP { get; set; }
        public short CurrentSS { get; set; }
        public short MaxSS { get; }
        public short PermanentSS { get; set; }
        public short CurrentXP { get; set; }
        public short NextLevelXP { get; set; }
        public short ArmourClass { get; }
        public short AttackBonus { get; set; }

        public short Strength { get; set; }
        public short Dexterity { get; set; }
        public short Constitution { get; set; }
        public short Intelligence { get; set; }
        public short Wisdom { get; set; }
        public short Charisma { get; set; }

        public short StrengthModifier { get; }
        public short DexterityModifier { get; }
        public short ConstitutionModifier { get; }
        public short IntelligenceModifier { get; }
        public short WisdomModifier { get; }
        public short CharismaModifier { get; }

        public short PhysicalSave { get; }
        public short MentalSave { get; }
        public short EvasionSave { get; }


        public void OnGet()
        {
            
        }
    }
}
