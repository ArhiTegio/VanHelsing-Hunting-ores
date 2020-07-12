using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingСores
{
    public class Characteristic
    {
        public NameCharacteristic Name;
        public TypeCharacteristic Type;

        public Characteristic(TypeCharacteristic type, NameCharacteristic name)
        {
            Name = name;
            Type = type;
        }


        public static Dictionary<TypeCharacteristic, List<Characteristic>> AllCharacteristics = new Dictionary<TypeCharacteristic, List<Characteristic>>
        {
            { TypeCharacteristic.Attraction, new List<Characteristic>
            {
                new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_FlowingWater),
                new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_Light),
                new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_LoudSound),
                new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_SmellHunter),
            } },
            { TypeCharacteristic.Inhabitancy, new List<Characteristic>
            {
                new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Forest),
                new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Mountains),
                new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Plain),
                new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Swamp),
            } },
            { TypeCharacteristic.Size, new List<Characteristic>
            {
                new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Half),
                new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Abreast),
                new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Double),
                new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Gigant),
            } },
            { TypeCharacteristic.Social, new List<Characteristic>
            {
                new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Famely),
                new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Group),
                new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Have),
                new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Loner),
            } },
            { TypeCharacteristic.Weak, new List<Characteristic>
            {
                new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_GoiterThroat),
                new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_ManeBack),
                new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_ThinLeg),
                new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_Water),
            } },
            { TypeCharacteristic.WeakMetal, new List<Characteristic>
            {
                new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Acid),
                new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Gold),
                new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Silver),
                new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Wood),
            } },
        };
    }

    public enum TypeCharacteristic 
    {
        Size,
        Social,
        Inhabitancy,
        Attraction,
        Weak,
        WeakMetal
    }

    public enum NameCharacteristic
    {
        Unknown, 
        Size_Half, Size_Abreast, Size_Double, Size_Gigant,
        Social_Loner, Social_Famely, Social_Group, Social_Have,
        Inhabitancy_Plain, Inhabitancy_Forest, Inhabitancy_Mountains, Inhabitancy_Swamp,
        Attraction_Light, Attraction_LoudSound, Attraction_FlowingWater, Attraction_SmellHunter,
        Weak_ThinLeg, Weak_GoiterThroat, Weak_ManeBack, Weak_Water,
        WeakMetal_Silver, WeakMetal_Acid, WeakMetal_Gold, WeakMetal_Wood
    }
}
