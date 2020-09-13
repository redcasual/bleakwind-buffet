using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using BreakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreesReturnsAllEntrees()
        {
            List<IOrderItem> entree = (List<IOrderItem>)Menu.Entrees();
            Assert.Collection(entree,
                item => Assert.Equal(new BriarheartBurger().ToString(), item.ToString()),
                item => Assert.Equal(new DoubleDraugr().ToString(), item.ToString()),
                item => Assert.Equal(new GardenOrcOmelette().ToString(), item.ToString()),
                item => Assert.Equal(new PhillyPoacher().ToString(), item.ToString()),
                item => Assert.Equal(new SmokehouseSkeleton().ToString(), item.ToString()),
                item => Assert.Equal(new ThalmorTriple().ToString(), item.ToString()),
                item => Assert.Equal(new ThugsTBone().ToString(), item.ToString())
                );
        }

        [Fact]
        public void SidesReturnsAllSides()
        {
            DragonbornWaffleFries dwf1 = new DragonbornWaffleFries();
            dwf1.Size = Size.Large;
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            dwf2.Size = Size.Medium;
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf3.Size = Size.Small;

            FriedMiraak fm1 = new FriedMiraak();
            fm1.Size = Size.Large;
            FriedMiraak fm2 = new FriedMiraak();
            fm2.Size = Size.Medium;
            FriedMiraak fm3 = new FriedMiraak();
            fm3.Size = Size.Small;

            MadOtarGrits mog1 = new MadOtarGrits();
            mog1.Size = Size.Large;
            MadOtarGrits mog2 = new MadOtarGrits();
            mog2.Size = Size.Medium;
            MadOtarGrits mog3 = new MadOtarGrits();
            mog3.Size = Size.Small;

            VokunSalad vs1 = new VokunSalad();
            vs1.Size = Size.Large;
            VokunSalad vs2 = new VokunSalad();
            vs2.Size = Size.Medium;
            VokunSalad vs3 = new VokunSalad();
            vs3.Size = Size.Small;

            List<IOrderItem> side = (List<IOrderItem>)Menu.Sides();
            Assert.Collection(side,
                item => Assert.Equal(dwf1.ToString(), item.ToString()),
                item => Assert.Equal(dwf2.ToString(), item.ToString()),
                item => Assert.Equal(dwf3.ToString(), item.ToString()),
                item => Assert.Equal(fm1.ToString(), item.ToString()),
                item => Assert.Equal(fm2.ToString(), item.ToString()),
                item => Assert.Equal(fm3.ToString(), item.ToString()),
                item => Assert.Equal(mog1.ToString(), item.ToString()),
                item => Assert.Equal(mog2.ToString(), item.ToString()),
                item => Assert.Equal(mog3.ToString(), item.ToString()),
                item => Assert.Equal(vs1.ToString(), item.ToString()),
                item => Assert.Equal(vs2.ToString(), item.ToString()),
                item => Assert.Equal(vs3.ToString(), item.ToString())
                );
        }

        [Fact]
        public void DrinksReturnsAllDrinks()
        {
            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            aj1.Size = Size.Large;
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Size.Medium;
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Size.Small;

            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            cc1.Size = Size.Large;
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Size.Medium;
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Size.Small;

            MarkarthMilk mm1 = new MarkarthMilk();
            mm1.Size = Size.Large;
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Size.Medium;
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Size.Small;

            WarriorWater ww1 = new WarriorWater();
            ww1.Size = Size.Large;
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Size.Medium;
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Size.Small;

            SailorSoda ss1_1 = new SailorSoda();
            ss1_1.Flavor = SodaFlavor.Blackberry;
            ss1_1.Size = Size.Large;
            SailorSoda ss1_2 = new SailorSoda();
            ss1_2.Flavor = SodaFlavor.Blackberry;
            ss1_2.Size = Size.Medium;
            SailorSoda ss1_3 = new SailorSoda();
            ss1_3.Flavor = SodaFlavor.Blackberry;
            ss1_3.Size = Size.Small;

            SailorSoda ss2_1 = new SailorSoda();
            ss2_1.Flavor = SodaFlavor.Cherry;
            ss2_1.Size = Size.Large;
            SailorSoda ss2_2 = new SailorSoda();
            ss2_2.Flavor = SodaFlavor.Cherry;
            ss2_2.Size = Size.Medium;
            SailorSoda ss2_3 = new SailorSoda();
            ss2_3.Flavor = SodaFlavor.Cherry;
            ss2_3.Size = Size.Small;

            SailorSoda ss3_1 = new SailorSoda();
            ss3_1.Flavor = SodaFlavor.Grapefruit;
            ss3_1.Size = Size.Large;
            SailorSoda ss3_2 = new SailorSoda();
            ss3_2.Flavor = SodaFlavor.Grapefruit;
            ss3_2.Size = Size.Medium;
            SailorSoda ss3_3 = new SailorSoda();
            ss3_3.Flavor = SodaFlavor.Grapefruit;
            ss3_3.Size = Size.Small;

            SailorSoda ss4_1 = new SailorSoda();
            ss4_1.Flavor = SodaFlavor.Lemon;
            ss4_1.Size = Size.Large;
            SailorSoda ss4_2 = new SailorSoda();
            ss4_2.Flavor = SodaFlavor.Lemon;
            ss4_2.Size = Size.Medium;
            SailorSoda ss4_3 = new SailorSoda();
            ss4_3.Flavor = SodaFlavor.Lemon;
            ss4_3.Size = Size.Small;

            SailorSoda ss5_1 = new SailorSoda();
            ss5_1.Flavor = SodaFlavor.Peach;
            ss5_1.Size = Size.Large;
            SailorSoda ss5_2 = new SailorSoda();
            ss5_2.Flavor = SodaFlavor.Peach;
            ss5_2.Size = Size.Medium;
            SailorSoda ss5_3 = new SailorSoda();
            ss5_3.Flavor = SodaFlavor.Peach;
            ss5_3.Size = Size.Small;

            SailorSoda ss6_1 = new SailorSoda();
            ss6_1.Flavor = SodaFlavor.Watermelon;
            ss6_1.Size = Size.Large;
            SailorSoda ss6_2 = new SailorSoda();
            ss6_2.Flavor = SodaFlavor.Watermelon;
            ss6_2.Size = Size.Medium;
            SailorSoda ss6_3 = new SailorSoda();
            ss6_3.Flavor = SodaFlavor.Watermelon;
            ss6_3.Size = Size.Small;

            List<IOrderItem> drink = (List<IOrderItem>)Menu.Drinks();
            Assert.Collection(drink,
                item => Assert.Equal(aj1.ToString(), item.ToString()),
                item => Assert.Equal(aj2.ToString(), item.ToString()),
                item => Assert.Equal(aj3.ToString(), item.ToString()),
                item => Assert.Equal(cc1.ToString(), item.ToString()),
                item => Assert.Equal(cc2.ToString(), item.ToString()),
                item => Assert.Equal(cc3.ToString(), item.ToString()),
                item => Assert.Equal(mm1.ToString(), item.ToString()),
                item => Assert.Equal(mm2.ToString(), item.ToString()),
                item => Assert.Equal(mm3.ToString(), item.ToString()),
                item => Assert.Equal(ww1.ToString(), item.ToString()),
                item => Assert.Equal(ww2.ToString(), item.ToString()),
                item => Assert.Equal(ww3.ToString(), item.ToString()),
                item => Assert.Equal(ss1_1.ToString(), item.ToString()),
                item => Assert.Equal(ss1_2.ToString(), item.ToString()),
                item => Assert.Equal(ss1_3.ToString(), item.ToString()),
                item => Assert.Equal(ss2_1.ToString(), item.ToString()),
                item => Assert.Equal(ss2_2.ToString(), item.ToString()),
                item => Assert.Equal(ss2_3.ToString(), item.ToString()),
                item => Assert.Equal(ss3_1.ToString(), item.ToString()),
                item => Assert.Equal(ss3_2.ToString(), item.ToString()),
                item => Assert.Equal(ss3_3.ToString(), item.ToString()),
                item => Assert.Equal(ss4_1.ToString(), item.ToString()),
                item => Assert.Equal(ss4_2.ToString(), item.ToString()),
                item => Assert.Equal(ss4_3.ToString(), item.ToString()),
                item => Assert.Equal(ss5_1.ToString(), item.ToString()),
                item => Assert.Equal(ss5_2.ToString(), item.ToString()),
                item => Assert.Equal(ss5_3.ToString(), item.ToString()),
                item => Assert.Equal(ss6_1.ToString(), item.ToString()),
                item => Assert.Equal(ss6_2.ToString(), item.ToString()),
                item => Assert.Equal(ss6_3.ToString(), item.ToString())
                );
        }

        [Fact]
        public void AllItemsOnMenu()
        {
            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            aj1.Size = Size.Large;
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Size.Medium;
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Size.Small;

            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            cc1.Size = Size.Large;
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Size.Medium;
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Size.Small;

            MarkarthMilk mm1 = new MarkarthMilk();
            mm1.Size = Size.Large;
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Size.Medium;
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Size.Small;

            WarriorWater ww1 = new WarriorWater();
            ww1.Size = Size.Large;
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Size.Medium;
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Size.Small;

            SailorSoda ss1_1 = new SailorSoda();
            ss1_1.Flavor = SodaFlavor.Blackberry;
            ss1_1.Size = Size.Large;
            SailorSoda ss1_2 = new SailorSoda();
            ss1_2.Flavor = SodaFlavor.Blackberry;
            ss1_2.Size = Size.Medium;
            SailorSoda ss1_3 = new SailorSoda();
            ss1_3.Flavor = SodaFlavor.Blackberry;
            ss1_3.Size = Size.Small;

            SailorSoda ss2_1 = new SailorSoda();
            ss2_1.Flavor = SodaFlavor.Cherry;
            ss2_1.Size = Size.Large;
            SailorSoda ss2_2 = new SailorSoda();
            ss2_2.Flavor = SodaFlavor.Cherry;
            ss2_2.Size = Size.Medium;
            SailorSoda ss2_3 = new SailorSoda();
            ss2_3.Flavor = SodaFlavor.Cherry;
            ss2_3.Size = Size.Small;

            SailorSoda ss3_1 = new SailorSoda();
            ss3_1.Flavor = SodaFlavor.Grapefruit;
            ss3_1.Size = Size.Large;
            SailorSoda ss3_2 = new SailorSoda();
            ss3_2.Flavor = SodaFlavor.Grapefruit;
            ss3_2.Size = Size.Medium;
            SailorSoda ss3_3 = new SailorSoda();
            ss3_3.Flavor = SodaFlavor.Grapefruit;
            ss3_3.Size = Size.Small;

            SailorSoda ss4_1 = new SailorSoda();
            ss4_1.Flavor = SodaFlavor.Lemon;
            ss4_1.Size = Size.Large;
            SailorSoda ss4_2 = new SailorSoda();
            ss4_2.Flavor = SodaFlavor.Lemon;
            ss4_2.Size = Size.Medium;
            SailorSoda ss4_3 = new SailorSoda();
            ss4_3.Flavor = SodaFlavor.Lemon;
            ss4_3.Size = Size.Small;

            SailorSoda ss5_1 = new SailorSoda();
            ss5_1.Flavor = SodaFlavor.Peach;
            ss5_1.Size = Size.Large;
            SailorSoda ss5_2 = new SailorSoda();
            ss5_2.Flavor = SodaFlavor.Peach;
            ss5_2.Size = Size.Medium;
            SailorSoda ss5_3 = new SailorSoda();
            ss5_3.Flavor = SodaFlavor.Peach;
            ss5_3.Size = Size.Small;

            SailorSoda ss6_1 = new SailorSoda();
            ss6_1.Flavor = SodaFlavor.Watermelon;
            ss6_1.Size = Size.Large;
            SailorSoda ss6_2 = new SailorSoda();
            ss6_2.Flavor = SodaFlavor.Watermelon;
            ss6_2.Size = Size.Medium;
            SailorSoda ss6_3 = new SailorSoda();
            ss6_3.Flavor = SodaFlavor.Watermelon;
            ss6_3.Size = Size.Small;

            DragonbornWaffleFries dwf1 = new DragonbornWaffleFries();
            dwf1.Size = Size.Large;
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            dwf2.Size = Size.Medium;
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf3.Size = Size.Small;

            FriedMiraak fm1 = new FriedMiraak();
            fm1.Size = Size.Large;
            FriedMiraak fm2 = new FriedMiraak();
            fm2.Size = Size.Medium;
            FriedMiraak fm3 = new FriedMiraak();
            fm3.Size = Size.Small;

            MadOtarGrits mog1 = new MadOtarGrits();
            mog1.Size = Size.Large;
            MadOtarGrits mog2 = new MadOtarGrits();
            mog2.Size = Size.Medium;
            MadOtarGrits mog3 = new MadOtarGrits();
            mog3.Size = Size.Small;

            VokunSalad vs1 = new VokunSalad();
            vs1.Size = Size.Large;
            VokunSalad vs2 = new VokunSalad();
            vs2.Size = Size.Medium;
            VokunSalad vs3 = new VokunSalad();
            vs3.Size = Size.Small;

            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
            Assert.Collection(menu,
                item => Assert.Equal(aj1.ToString(), item.ToString()),
                item => Assert.Equal(aj2.ToString(), item.ToString()),
                item => Assert.Equal(aj3.ToString(), item.ToString()),
                item => Assert.Equal(cc1.ToString(), item.ToString()),
                item => Assert.Equal(cc2.ToString(), item.ToString()),
                item => Assert.Equal(cc3.ToString(), item.ToString()),
                item => Assert.Equal(mm1.ToString(), item.ToString()),
                item => Assert.Equal(mm2.ToString(), item.ToString()),
                item => Assert.Equal(mm3.ToString(), item.ToString()),
                item => Assert.Equal(ww1.ToString(), item.ToString()),
                item => Assert.Equal(ww2.ToString(), item.ToString()),
                item => Assert.Equal(ww3.ToString(), item.ToString()),
                item => Assert.Equal(ss1_1.ToString(), item.ToString()),
                item => Assert.Equal(ss1_2.ToString(), item.ToString()),
                item => Assert.Equal(ss1_3.ToString(), item.ToString()),
                item => Assert.Equal(ss2_1.ToString(), item.ToString()),
                item => Assert.Equal(ss2_2.ToString(), item.ToString()),
                item => Assert.Equal(ss2_3.ToString(), item.ToString()),
                item => Assert.Equal(ss3_1.ToString(), item.ToString()),
                item => Assert.Equal(ss3_2.ToString(), item.ToString()),
                item => Assert.Equal(ss3_3.ToString(), item.ToString()),
                item => Assert.Equal(ss4_1.ToString(), item.ToString()),
                item => Assert.Equal(ss4_2.ToString(), item.ToString()),
                item => Assert.Equal(ss4_3.ToString(), item.ToString()),
                item => Assert.Equal(ss5_1.ToString(), item.ToString()),
                item => Assert.Equal(ss5_2.ToString(), item.ToString()),
                item => Assert.Equal(ss5_3.ToString(), item.ToString()),
                item => Assert.Equal(ss6_1.ToString(), item.ToString()),
                item => Assert.Equal(ss6_2.ToString(), item.ToString()),
                item => Assert.Equal(ss6_3.ToString(), item.ToString()),
                item => Assert.Equal(new BriarheartBurger().ToString(), item.ToString()),
                item => Assert.Equal(new DoubleDraugr().ToString(), item.ToString()),
                item => Assert.Equal(new GardenOrcOmelette().ToString(), item.ToString()),
                item => Assert.Equal(new PhillyPoacher().ToString(), item.ToString()),
                item => Assert.Equal(new SmokehouseSkeleton().ToString(), item.ToString()),
                item => Assert.Equal(new ThalmorTriple().ToString(), item.ToString()),
                item => Assert.Equal(new ThugsTBone().ToString(), item.ToString()),
                item => Assert.Equal(dwf1.ToString(), item.ToString()),
                item => Assert.Equal(dwf2.ToString(), item.ToString()),
                item => Assert.Equal(dwf3.ToString(), item.ToString()),
                item => Assert.Equal(fm1.ToString(), item.ToString()),
                item => Assert.Equal(fm2.ToString(), item.ToString()),
                item => Assert.Equal(fm3.ToString(), item.ToString()),
                item => Assert.Equal(mog1.ToString(), item.ToString()),
                item => Assert.Equal(mog2.ToString(), item.ToString()),
                item => Assert.Equal(mog3.ToString(), item.ToString()),
                item => Assert.Equal(vs1.ToString(), item.ToString()),
                item => Assert.Equal(vs2.ToString(), item.ToString()),
                item => Assert.Equal(vs3.ToString(), item.ToString())
                );
        }
    }
}
