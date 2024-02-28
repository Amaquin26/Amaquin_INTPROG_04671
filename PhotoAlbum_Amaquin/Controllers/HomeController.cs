using Microsoft.AspNetCore.Mvc;
using PhotoAlbum_Amaquin.Models;
using System.Diagnostics;

namespace PhotoAlbum_Amaquin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Heroes()
        {
            var imageFolder = "~/images/heroes/";

            var heroesList = new List<Heroes>
            {
                new Heroes
                {
                    Name="Sniper",
                    ImageSource=$"{imageFolder}agility/sniper-hero.jpg",
                    Attribute="Agility",
                    BaseAttack=43,
                    BaseArmor=3.5f,
                    BaseMovespeed=285,
                    AttackType="Range",
                    Health=538,
                    HealthRegen=2.2f,
                    Mana=255,
                    ManaRegen=0.8f,
                    Description="Sniper is arguably the most recommended hero for beginners. It can attack enemies in extremely long distance."
                },
                new Heroes
                {
                    Name="Drow Ranger",
                    ImageSource=$"{imageFolder}agility/drow-hero.png",
                    Attribute="Agility",
                    BaseAttack=52,
                    BaseArmor=3.3f,
                    BaseMovespeed=300,
                    AttackType="Range",
                    Health=472,
                    HealthRegen=1.9f,
                    Mana=255,
                    ManaRegen=0.8f,
                    Description="Drow Ranger is a great range hero dealing high damage and slows enemies. Great for beginners to learn."
                },
                new Heroes
                {
                    Name="Weaver",
                    ImageSource=$"{imageFolder}agility/weaver-hero.jpg",
                    Attribute="Agility",
                    BaseAttack=57,
                    BaseArmor=3.8f,
                    BaseMovespeed=275,
                    AttackType="Range",
                    Health=472,
                    HealthRegen=2.8f,
                    Mana=315,
                    ManaRegen=1.5f,
                    Description="Weaver is a range hero that can go invisible to chase and attack enemies. This is a more advance hero since it may require you to be more efficient with its spell."
                },
                new Heroes
                {
                    Name="Morphling",
                    ImageSource=$"{imageFolder}agility/morphling-hero.jpg",
                    Attribute="Agility",
                    BaseAttack=37,
                    BaseArmor=2.0f,
                    BaseMovespeed=285,
                    AttackType="Range",
                    Health=626,
                    HealthRegen=2.8f,
                    Mana=303,
                    ManaRegen=1.5f,
                    Description="Morphling can deal extremely high damage and can shift attributes and is challenging even for advance players. Morphling is almost unstoppable if played correctly."
                },
                new Heroes
                {
                    Name="Meepo",
                    ImageSource=$"{imageFolder}agility/meepo-hero.jpg",
                    Attribute="Agility",
                    BaseAttack=49,
                    BaseArmor=6.8f,
                    BaseMovespeed=330,
                    AttackType="Melee",
                    Health=648,
                    HealthRegen=2.7f,
                    Mana=291,
                    ManaRegen=1.2f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Wraith King",
                    ImageSource=$"{imageFolder}strength/wraith_king-hero.png",
                    Attribute="Strength",
                    BaseAttack=61,
                    BaseArmor=1.7f,
                    BaseMovespeed=315,
                    AttackType="Melee",
                    Health=604,
                    HealthRegen=2.7f,
                    Mana=291,
                    ManaRegen=0.9f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Dragon Knigth",
                    ImageSource=$"{imageFolder}strength/dragon_knight-hero.png",
                    Attribute="Strength",
                    BaseAttack=58,
                    BaseArmor=2.7f,
                    BaseMovespeed=315,
                    AttackType="Melee",
                    Health=582,
                    HealthRegen=2.4f,
                    Mana=291,
                    ManaRegen=0.9f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Alchemist",
                    ImageSource=$"{imageFolder}strength/alchemist-hero.png",
                    Attribute="Strength",
                    BaseAttack=53,
                    BaseArmor=3.7f,
                    BaseMovespeed=295,
                    AttackType="Melee",
                    Health=626,
                    HealthRegen=2.5f,
                    Mana=375,
                    ManaRegen=1.2f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Tusk",
                    ImageSource=$"{imageFolder}strength/tusk-hero.png",
                    Attribute="Strength",
                    BaseAttack=52,
                    BaseArmor=4.8f,
                    BaseMovespeed=310,
                    AttackType="Melee",
                    Health=626,
                    HealthRegen=3.3f,
                    Mana=291,
                    ManaRegen=1.4f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Primal Beast",
                    ImageSource=$"{imageFolder}strength/primal_beast-hero.png",
                    Attribute="Strength",
                    BaseAttack=63,
                    BaseArmor=4.5f,
                    BaseMovespeed=310,
                    AttackType="Melee",
                    Health=692,
                    HealthRegen=2.9f,
                    Mana=267,
                    ManaRegen=0.8f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Cystal Maiden",
                    ImageSource=$"{imageFolder}intelligence/cystal_maiden-hero.png",
                    Attribute="Intelligence",
                    BaseAttack=51,
                    BaseArmor=2.7f,
                    BaseMovespeed=280,
                    AttackType="Range",
                    Health=494,
                    HealthRegen=2.0f,
                    Mana=291,
                    ManaRegen=1.4f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Disruptor",
                    ImageSource=$"{imageFolder}intelligence/disruptor-hero.png",
                    Attribute="Intelligence",
                    BaseAttack=49,
                    BaseArmor=2.5f,
                    BaseMovespeed=295,
                    AttackType="Range",
                    Health=582,
                    HealthRegen=2.4f,
                    Mana=315,
                    ManaRegen=1.0f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Jakiro",
                    ImageSource=$"{imageFolder}intelligence/jakiro-hero.png",
                    Attribute="Intelligence",
                    BaseAttack=57,
                    BaseArmor=3.5f,
                    BaseMovespeed=290,
                    AttackType="Range",
                    Health=670,
                    HealthRegen=2.8f,
                    Mana=387,
                    ManaRegen=1.3f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Puck",
                    ImageSource=$"{imageFolder}intelligence/puck-hero.png",
                    Attribute="Intelligence",
                    BaseAttack=49,
                    BaseArmor=0.7f,
                    BaseMovespeed=290,
                    AttackType="Range",
                    Health=494,
                    HealthRegen=2.2f,
                    Mana=351,
                    ManaRegen=1.6f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Tinker",
                    ImageSource=$"{imageFolder}intelligence/tinker-hero.png",
                    Attribute="Intelligence",
                    BaseAttack=55,
                    BaseArmor=4.8f,
                    BaseMovespeed=290,
                    AttackType="Range",
                    Health=538,
                    HealthRegen=2.2f,
                    Mana=435,
                    ManaRegen=2.2f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Mirana",
                    ImageSource=$"{imageFolder}universal/mirana-hero.png",
                    Attribute="Universal",
                    BaseAttack=43,
                    BaseArmor=2.0f,
                    BaseMovespeed=290,
                    AttackType="Range",
                    Health=560,
                    HealthRegen=2.2f,
                    Mana=339,
                    ManaRegen=1.5f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Dazzle",
                    ImageSource=$"{imageFolder}universal/dazzle-hero.png",
                    Attribute="Universal",
                    BaseAttack=50,
                    BaseArmor=3.3f,
                    BaseMovespeed=305,
                    AttackType="Range",
                    Health=516,
                    HealthRegen=2.1f,
                    Mana=375,
                    ManaRegen=1.5f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Timbersaw",
                    ImageSource=$"{imageFolder}universal/timbersaw-hero.jpg",
                    Attribute="Universal",
                    BaseAttack=52,
                    BaseArmor=2.7f,
                    BaseMovespeed=285,
                    AttackType="Melee",
                    Health=714,
                    HealthRegen=3.0f,
                    Mana=351,
                    ManaRegen=1.6f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Invoker",
                    ImageSource=$"{imageFolder}universal/invoker-hero.png",
                    Attribute="Universal",
                    BaseAttack=41,
                    BaseArmor=1.3f,
                    BaseMovespeed=285,
                    AttackType="Range",
                    Health=538,
                    HealthRegen=2.4f,
                    Mana=303,
                    ManaRegen=0.9f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },
                new Heroes
                {
                    Name="Chen",
                    ImageSource=$"{imageFolder}universal/chen-hero.png",
                    Attribute="Universal",
                    BaseAttack=51,
                    BaseArmor=1.5f,
                    BaseMovespeed=305,
                    AttackType="Range",
                    Health=626,
                    HealthRegen=2.5f,
                    Mana=303,
                    ManaRegen=1.5f,
                    Description="Did I say that you can only play one hero in a match? Well, not with this hero (not exactly). You will control up to 5 instances of this hero. Sounds cool but every meepo will die if one of them die. Extremely difficult to master."
                },

            };

            var groupedHeroes = heroesList.GroupBy(item => item.Attribute).ToDictionary(
                group => group.Key, 
                group => group.ToList()
            ); 

            return View(groupedHeroes);
        }

        public IActionResult Items()
        {
            var imageFolder = "~/images/items/";

            var itemList = new List<Items>
            {
                new Items
                {
                    Name="Tango",
                    ImageSource=$"{imageFolder}laning_phase/tango.png",
                    GoldCost=200,
                    Description="Consumes a target tree to gain 7 health regeneration for 16 seconds.",
                    Group="Laning_Phase"
                },
                new Items
                {
                    Name="Iron Branch",
                    ImageSource=$"{imageFolder}laning_phase/iron-branch.png",
                    GoldCost=50,
                    Description="Gain 1 additional points for each attributes.",
                    Group="Laning_Phase"
                },
                new Items
                {
                    Name="Healing Salve",
                    ImageSource=$"{imageFolder}laning_phase/healing-salve.png",
                    GoldCost=100,
                    Description="Grants 30 health regeneration to the target for 13 seconds.",
                    Group="Laning_Phase"
                },
                new Items
                {
                    Name="Clarity",
                    ImageSource=$"{imageFolder}laning_phase/clarity.png",
                    GoldCost=50,
                    Description="Regenerates 6 mana per second for 25 seconds.",
                    Group="Laning_Phase"
                },    
                new Items
                {
                    Name="Magic Stick",
                    ImageSource=$"{imageFolder}laning_phase/magic-stick.png",
                    GoldCost=200,
                    Description="Max 10 charges. Gains a charge whenever a visible enemy within 1200 range uses an ability.",
                    Group="Laning_Phase"
                },
                new Items
                {
                    Name="Vanguard",
                    ImageSource=$"{imageFolder}armor_health/Vanguard.png",
                    GoldCost=1700,
                    Description="Grants a 60% chance to block 50 damage from incoming attacks on melee heroes, and 25 damage on ranged.",
                    Group="Armor_Health"
                },
                new Items
                {
                    Name="Blade Mail",
                    ImageSource=$"{imageFolder}armor_health/Blade_Mail.png",
                    GoldCost=2100,
                    Description="For 5.5 seconds, the damage returned from all sources is increased by 85%.",
                    Group="Armor_Health"
                },
                new Items
                {
                    Name="Assault Cuirass",
                    ImageSource=$"{imageFolder}armor_health/Assault_Cuirass.png",
                    GoldCost=5125,
                    Description="Grants 30 attack speed and 5 armor to nearby allied units and structures, and decreases nearby enemy unit and structure armor by 5.",
                    Group="Armor_Health"
                },
                new Items
                {
                    Name="Heart of Tarrasque",
                    ImageSource=$"{imageFolder}armor_health/Heart_of_Tarrasque.png",
                    GoldCost=5200,
                    Description="Can fully regenerate the wielder's health within 62.5 seconds.",
                    Group="Armor_Health"
                },
                new Items
                {
                    Name="Shiva's Guard",
                    ImageSource=$"{imageFolder}armor_health/Shivas_Guard.png",
                    GoldCost=5175,
                    Description="Emits a freezing wave that causes enemies to take 15% more damage from spells for 16 seconds, deals 200 magical damage to enemies and slows their movement by 40% for 4 seconds.",
                    Group="Armor_Health"
                },
                new Items
                {
                    Name="Butterfly",
                    ImageSource=$"{imageFolder}evasion_invisibility/Butterfly.png",
                    GoldCost=5450,
                    Description="+35% Evasion. Increases most heroes survivability against physical attacks by 53.85%.",
                    Group="Evasion_Invisibility"
                },
                new Items
                {
                    Name="Glimmer Cape",
                    ImageSource=$"{imageFolder}evasion_invisibility/Glimmer_Cape.png",
                    GoldCost=2150,
                    Description="After a 0.5 second delay, grants invisibility, 40 movement speed and a magic damage barrier that absorbs up to 300 damage to you or a target allied unit for 5 seconds.",
                    Group="Evasion_Invisibility"
                },
                new Items
                {
                    Name="Heaven's Halberd",
                    ImageSource=$"{imageFolder}evasion_invisibility/Heavens_Halberd.png",
                    GoldCost=3500,
                    Description="+25% Evasion. Prevents a target from attacking for 3 seconds on melee targets, and 5 seconds on ranged targets.",
                    Group="Evasion_Invisibility"
                },
                new Items
                {
                    Name="Radiance",
                    ImageSource=$"{imageFolder}evasion_invisibility/Radiance.png",
                    GoldCost=4700,
                    Description="+20% Evasion. When active, scorches enemies for 60 magical damage per second, and causes them to miss 15% of their attacks. Illusions deal 35 magical damage per second.",
                    Group="Evasion_Invisibility"
                },
                new Items
                {
                    Name="Shadow Blade",
                    ImageSource=$"{imageFolder}evasion_invisibility/Shadow_Blade.png",
                    GoldCost=3000,
                    Description="Makes you invisible for 14 seconds, or until you attack or cast a spell. While Shadow Walk is active, you move 20% faster and can move through units.",
                    Group="Evasion_Invisibility"
                },
                new Items
                {
                    Name="Black King Bar",
                    ImageSource=$"{imageFolder}resistance/Black_King_Bar.png",
                    GoldCost=4050,
                    Description="Applies a Basic Dispel. Grants 60% Magic resistance and immunity to pure and reflected damage. For the duration of the effect, any negative effect from enemy spells has no effect.",
                    Group="Resistance"
                },
                new Items
                {
                    Name="Eternal Shroud",
                    ImageSource=$"{imageFolder}resistance/Eternal_Shroud.png",
                    GoldCost=3600,
                    Description="Restores Mana equal to 20% of incoming enemy spell damage before reduction.",
                    Group="Resistance"
                },
                new Items
                {
                    Name="Mage Slayer",
                    ImageSource=$"{imageFolder}resistance/Mage_Slayer.png",
                    GoldCost=2825,
                    Description="Places a debuff when you attack enemies, dealing 25 damage per second and causing them to do 40% less spell damage for 3 seconds.",
                    Group="Resistance"
                },
                new Items
                {
                    Name="Pipe of Insight",
                    ImageSource=$"{imageFolder}resistance/Pipe_of_Insight.png",
                    GoldCost=3725,
                    Description="Gives a shield that blocks 450 magic damage to all nearby allies. Lasts 12 seconds.",
                    Group="Resistance"
                },
                new Items
                {
                    Name="Sange",
                    ImageSource=$"{imageFolder}resistance/Sange.png",
                    GoldCost=2000,
                    Description="+16% Status Resistance. Sange is an unusually accurate weapon, seeking weak points automatically.",
                    Group="Resistance"
                },
                
            };

            var groupedItems = itemList.GroupBy(item => item.Group).ToDictionary(
                group => group.Key,
                group => group.ToList()
            );

            return View(groupedItems);
        }

        public IActionResult Neutrals()
        {
            var imageFolder = "~/images/neutrals/";

            var neturalList = new List<Neutrals>{
                new Neutrals
                {
                    Name="Fell Spirit",
                    ImageSource=$"{imageFolder}small/Fell_spirit.jpg",
                    Health=400,
                    HealthRegen=0.5f,
                    XP=41,
                    Gold=20,
                    Description="Usually found in small camps near Tier 1 Towers.",
                    Group="Small"
                },
                new Neutrals
                {
                    Name="Harpy Scout",
                    ImageSource=$"{imageFolder}small/Harpy_scout.jpg",
                    Health=400,
                    HealthRegen=0.5f,
                    XP=41,
                    Gold=24,
                    Description="Usually found in small camps near Tier 1 Towers.",
                    Group="Small"
                },
                new Neutrals
                {
                    Name="Hill Troll Priest",
                    ImageSource=$"{imageFolder}small/Hill_troll_priest.jpg",
                    Health=450,
                    HealthRegen=0.5f,
                    XP=41,
                    Gold=21,
                    Description="Has the Heal and Mana Aura abilities.",
                    Group="Small"
                },
                new Neutrals
                {
                    Name="Kobold Soldier",
                    ImageSource=$"{imageFolder}small/Kobold_soldier.jpg",
                    Health=325,
                    HealthRegen=0.5f,
                    XP=25,
                    Gold=17,
                    Description="Usually found in small camps near Tier 1 Towers.",
                    Group="Small"
                },
                new Neutrals
                {
                    Name="Vhoul Assassin",
                    ImageSource=$"{imageFolder}small/Vhoul_assassin.jpg",
                    Health=370,
                    HealthRegen=0.5f,
                    XP=41,
                    Gold=21,
                    Description="Has the Envenomed Weapon ability.",
                    Group="Small"
                },
                new Neutrals
                {
                    Name="Centaur Courser",
                    ImageSource=$"{imageFolder}medium/Centaur_courser.jpg",
                    Health=320,
                    HealthRegen=0.5f,
                    XP=41,
                    Gold=20,
                    Description="Has the Cloak Aura ability.",
                    Group="Medium"
                },
                new Neutrals
                {
                    Name="Giant Wolf",
                    ImageSource=$"{imageFolder}medium/Giant_wolf.jpg",
                    Health=500,
                    HealthRegen=0.5f,
                    XP=50,
                    Gold=18,
                    Description="Has a damage reduction ability",
                    Group="Medium"
                },
                new Neutrals
                {
                    Name="Mud Golem",
                    ImageSource=$"{imageFolder}medium/Mud_golem.jpg",
                    Health=800,
                    HealthRegen=0.5f,
                    XP=42,
                    Gold=28,
                    Description="Has the Hurl Boulder and Shard Split abilities.",
                    Group="Medium"
                },
                new Neutrals
                {
                    Name="Ogre Frostmage",
                    ImageSource=$"{imageFolder}medium/Ogre_frostmage.jpg",
                    Health=600,
                    HealthRegen=0.5f,
                    XP=62,
                    Gold=31,
                    Description="Has the Ice Armor ability.",
                    Group="Medium"
                },
                new Neutrals
                {
                    Name="Satyr Mindstealer",
                    ImageSource=$"{imageFolder}medium/Satyr_mindstealer.jpg",
                    Health=600,
                    HealthRegen=0.5f,
                    XP=62,
                    Gold=27,
                    Description="Has the Mana Burn ability.",
                    Group="Medium"
                },
                new Neutrals
                {
                    Name="Centaur Conqueror",
                    ImageSource=$"{imageFolder}large/Centaur_conqueror.jpg",
                    Health=1100,
                    HealthRegen=0.5f,
                    XP=119,
                    Gold=66,
                    Description="Has the War Stomp ability.",
                    Group="Large"
                },
                new Neutrals
                {
                    Name="Dark Troll Summoner",
                    ImageSource=$"{imageFolder}large/Dark_troll_summoner.jpg",
                    Health=1100,
                    HealthRegen=0.5f,
                    XP=119,
                    Gold=54,
                    Description="Has the Raise Dead abilities.",
                    Group="Large"
                },
                new Neutrals
                {
                    Name="Hellbear Smasher",
                    ImageSource=$"{imageFolder}large/Hellbear_smasher.jpg",
                    Health=950,
                    HealthRegen=1,
                    XP=119,
                    Gold=76,
                    Description="Has the Thunder Clap and Swiftness Aura abilities.",
                    Group="Large"
                },
                new Neutrals
                {
                    Name="Satyr Tormenter",
                    ImageSource=$"{imageFolder}large/Satyr_tormenter.jpg",
                    Health=1100,
                    HealthRegen=1,
                    XP=119,
                    Gold=71,
                    Description="Has the Shockwave and Unholy Aura abilities.",
                    Group="Large"
                },
                new Neutrals
                {
                    Name="Wildwing Ripper",
                    ImageSource=$"{imageFolder}large/Wildwing_ripper.jpg",
                    Health=950,
                    HealthRegen=0.5f,
                    XP=119,
                    Gold=67,
                    Description="Has the Tornado and Toughness Aura abilities.",
                    Group="Large"
                },
                new Neutrals
                {
                    Name="Ancient Black Dragon",
                    ImageSource=$"{imageFolder}ancient/Ancient_black_dragon.jpg",
                    Health=2000,
                    HealthRegen=2,
                    XP=155,
                    Gold=135,
                    Description="Has the Fireball, Splash Attack, and Dragonhide Aura abilities.",
                    Group="Ancient"
                },
                new Neutrals
                {
                    Name="Ancient Granite Golem",
                    ImageSource=$"{imageFolder}ancient/Ancient_granite_golem.jpg",
                    Health=1700,
                    HealthRegen=1.5f,
                    XP=155,
                    Gold=107,
                    Description="Has the Granite Aura ability.",
                    Group="Ancient"
                },
                new Neutrals
                {
                    Name="Ancient Thunderhide",
                    ImageSource=$"{imageFolder}ancient/Ancient_thunderhide.jpg",
                    Health=1400,
                    HealthRegen=0.5f,
                    XP=155,
                    Gold=88,
                    Description="Has the Frenzy, War Drums Aura, and Slam abilities.",
                    Group="Ancient"
                },
                new Neutrals
                {
                    Name="Ancient Rumblehide",
                    ImageSource=$"{imageFolder}ancient/Ancient_rumblehide.jpg",
                    Health=800,
                    HealthRegen=0.5f,
                    XP=119,
                    Gold=61,
                    Description="Found in Ancient Thunderhide Camps.",
                    Group="Ancient"
                },
                new Neutrals
                {
                    Name="Ancient Prowler Shaman",
                    ImageSource=$"{imageFolder}ancient/Ancient_prowler_shaman.jpg",
                    Health=1200,
                    HealthRegen=0.5f,
                    XP=119,
                    Gold=86,
                    Description="Has the Desecrate and Petrify abilities.",
                    Group="Ancient"
                },
            };

            var groupedNeutral = neturalList.GroupBy(neutral => neutral.Group).ToDictionary(
                group => group.Key,
                group => group.ToList()
            );

            return View(groupedNeutral);
        }

        public IActionResult Players()
        {
            var imageFolder = "~/images/players/";

            var playerList = new List<Players>
            {
                new Players
                {
                    Name="Yatoro",
                    RealName="Illya Mulyarchuk",
                    ImageSource=$"{imageFolder}TI/Yatoro.png",
                    TeamRole="Carry",
                    ApproxWinning="$5,397,872",
                    Description="Illya \"Yatoro\" Mulyarchuk (born March 12, 2003) is a Ukrainian player who is currently playing for Team Spirit.",
                    Group="TI"
                },
                new Players
                {
                    Name="Larl",
                    RealName="Denis Sigitov",
                    ImageSource=$"{imageFolder}TI/Larl.png",
                    TeamRole="Solo Middle",
                    ApproxWinning="$1,453,531",
                    Description="Denis \"Larl\" Sigitov (born January 22, 2002) is a Russian player who is currently playing for Team Spirit.",
                    Group="TI"
                },
                new Players
                {
                    Name="Collapse",
                    RealName="Magomed Khalilov",
                    ImageSource=$"{imageFolder}TI/Collapse.png",
                    TeamRole="Offlaner",
                    ApproxWinning="$5,400,086",
                    Description="Magomed was spending a lot of his free time in Dota 2, and because of it he had some troubles with his parents while he was still studying in school so he was playing from PC cafes.",
                    Group="TI"
                },
                new Players
                {
                    Name="Mira",
                    RealName="Myroslav Kolpakov",
                    ImageSource=$"{imageFolder}TI/Mira.png",
                    TeamRole="Support",
                    ApproxWinning="$5,385,004",
                    Description="Myroslav \"Mira\" Kolpakov (born November 3, 1999) is a Ukrainian player who is currently playing for Team Spirit.",
                    Group="TI"
                },
                new Players
                {
                    Name="Miposhka",
                    RealName="Yaroslav Naidenov",
                    ImageSource=$"{imageFolder}TI/Miposhka.png",
                    TeamRole="Support/Captain",
                    ApproxWinning="$5,639,005",
                    Description="Yaroslav \"Miposhka\" Naidenov (born November 30, 1997) is a Russian player who is currently playing for Team Spirit.",
                    Group="TI"
                },
                new Players
                {
                    Name="Bob",
                    RealName="Mark Anthony A. Urbina",
                    ImageSource=$"{imageFolder}Filipino/Bob.png",
                    TeamRole="Solo Middle",
                    ApproxWinning="$91,852",
                    Description="Mark Anthony \"Bob\" Urbina (born September 13, 2000) is a Filipino player who is currently playing for Execration.",
                    Group="Filipino"
                },
                new Players
                {
                    Name="Armel",
                    RealName="Armel Paul Luna Tabios",
                    ImageSource=$"{imageFolder}Filipino/Armel.png",
                    TeamRole="Solo Middle",
                    ApproxWinning="$672,346",
                    Description="Armel \"Armel\" Tabios (born January 20, 2000) is a Filipino player who is currently playing for Aurora.",
                    Group="Filipino"
                },
                new Players
                {
                    Name="Kuku",
                    RealName="Carlo Palad",
                    ImageSource=$"{imageFolder}Filipino/Kuku.png",
                    TeamRole="Offlaner",
                    ApproxWinning="$1,040,482",
                    Description="Carlo \"Kuku\" Palad (born September 21, 1996) is a Filipino player who last played for Blacklist International.",
                    Group="Filipino"
                },
                new Players
                {
                    Name="Natsumi-",
                    RealName="John Anthony Vargas",
                    ImageSource=$"{imageFolder}Filipino/Natsumi.png",
                    TeamRole="Carry",
                    ApproxWinning="$126,133",
                    Description="Had the highest average kills per game (8.50) during Season 2 of the 2021 DPC SEA Upper Division.",
                    Group="Filipino"
                },
                new Players
                {
                    Name="Tims",
                    RealName="Timothy John Randrup",
                    ImageSource=$"{imageFolder}Filipino/Tims.png",
                    TeamRole="Support",
                    ApproxWinning="$1,006,144",
                    Description="Timothy John \"TIMS\" Randrup (born July 4, 1997) is a Filipino player who is currently playing for Blacklist International.",
                    Group="Filipino"
                },
                new Players
                {
                    Name="Ame",
                    RealName="Wang Chunyu",
                    ImageSource=$"{imageFolder}Chinese/Ame.jpg",
                    TeamRole="Carry",
                    ApproxWinning="$4,017,707",
                    Description="Wang \"Ame\" Chunyu (born April 7, 1997) is a Chinese player who is currently playing for Xtreme Gaming.",
                    Group="Chinese"
                },
                new Players
                {
                    Name="Faith",
                    RealName="Zeng Hongda",
                    ImageSource=$"{imageFolder}Chinese/Faith.jpg",
                    TeamRole="Coach",
                    ApproxWinning="$1,759,125",
                    Description="Zeng \"Faith\" Hongda (born February 6, 1992) is a Chinese Dota 2 player who last coached LBZS.",
                    Group="Chinese"
                },
                new Players
                {
                    Name="Monet",
                    RealName="Du Peng",
                    ImageSource=$"{imageFolder}Chinese/Monet.jpg",
                    TeamRole="Carry",
                    ApproxWinning="$1,464,043",
                    Description="Du \"Monet\" Peng (born September 25, 1999) is a Chinese player who is currently playing for G2.iG.",
                    Group="Chinese"
                },
                new Players
                {
                    Name="Old Chicken",
                    RealName="Wang Zhiyong",
                    ImageSource=$"{imageFolder}Chinese/Old_chicken.jpg",
                    TeamRole="Solo Middle",
                    ApproxWinning="$560,218",
                    Description="Wang \"old chicken\" Zhiyong (born May 26, 1993) is an inactive Chinese player who last played for Team Sirius.",
                    Group="Chinese"
                },
                new Players
                {
                    Name="Paparazi",
                    RealName="Zhang Chengjun",
                    ImageSource=$"{imageFolder}Chinese/Paparazi.png",
                    TeamRole="Solo Middle",
                    ApproxWinning="$1,241,845",
                    Description="His last team Xtreme Gaming announced his retirement from the competitive scene on July 31, 2023.",
                    Group="Chinese"
                },
                new Players
                {
                    Name="Mercader",
                    RealName="Li Ruofei",
                    ImageSource=$"{imageFolder}Banned/Mercader.png",
                    TeamRole="Support",
                    ApproxWinning="$22,381",
                    Description="In March 2023, he is suspended by Valve and Perfect World for one year due to foul play.",
                    Group="Banned"
                },
                new Players
                {
                    Name="Mks",
                    RealName="Wong Sim An",
                    ImageSource=$"{imageFolder}Banned/Mks.png",
                    TeamRole="Carry",
                    ApproxWinning="$20,383",
                    Description="In March 2023, he is permanently banned by Valve and Perfect World due to foul play.",
                    Group="Banned"
                },
                new Players
                {
                    Name="Nevermine",
                    RealName="Somsak Chanthavisouk",
                    ImageSource=$"{imageFolder}Banned/Nevermine.png",
                    TeamRole="Offlaner",
                    ApproxWinning="$19,197",
                    Description="On March 2023, he is suspended by Valve and Perfect World for two years due to foul play.",
                    Group="Banned"
                },
                new Players
                {
                    Name="Rayy",
                    RealName="Raymond Then Wan Jia",
                    ImageSource=$"{imageFolder}Banned/Rayy.png",
                    TeamRole="Support",
                    ApproxWinning="$8,076",
                    Description="On March 2023, he is suspended by Valve and Perfect World for two years due to foul play.",
                    Group="Banned"
                },
                new Players
                {
                    Name="Son Goku",
                    RealName="Lin Shiyang",
                    ImageSource=$"{imageFolder}Banned/SonGoku.png",
                    TeamRole="Support",
                    ApproxWinning="$101,788",
                    Description="On March 2023, he is suspended by Valve and Perfect World for two years due to foul play.",
                    Group="Banned"
                },
            };

            var groupedPlayers = playerList.GroupBy(player => player.Group).ToDictionary(
                group => group.Key,
                group => group.ToList()
            );

            return View(groupedPlayers);
        }

        public IActionResult Cosmetics()
        {
            var imageFolder = "~/images/cosmetics/";

            var cosmeticList = new List<Cosmetics>
            {
                new Cosmetics
                {
                    Name="Jade Baby Roshan",
                    ImageSource=$"{imageFolder}expensive/jade_baby_roshan.png",
                    Cost="$1409.29",
                    Date="as of Feb. 28, 2024",
                    Description="This little guy's true value is always on display in the heart of battle.",
                    Group="Expensive"
                },
                new Cosmetics
                {
                    Name="Axe of Phractos",
                    ImageSource=$"{imageFolder}expensive/axe_of_phractos.png",
                    Cost="$709.92",
                    Date="as of Feb. 28, 2024",
                    Description="An instrument of keen-edged trauma, the Axe of Phractos embodies power over grace. Newly forged by the steelworks of Ulmarain, searing heat still shimmers across its facets--a cauterisation in waiting.",
                    Group="Expensive"
                },           
                new Cosmetics
                {
                    Name="Golden Silent Wake",
                    ImageSource=$"{imageFolder}expensive/gold_silent_wake.png",
                    Cost="$690",
                    Date="as of Feb. 28, 2024",
                    Description="The midwinter drifts scatter in a silent gust from the passing ranger before settling gently back to earth, as if they were never disturbed at all.",
                    Group="Expensive"
                },
                new Cosmetics
                {
                    Name="Shattered Greatsword",
                    ImageSource=$"{imageFolder}expensive/shattered_greatsword.png",
                    Cost="$405.18",
                    Date="as of Feb. 28, 2024",
                    Description="Used by Sven.",
                    Group="Expensive"
                },
                new Cosmetics
                {
                    Name="Dragonclaw Hook",
                    ImageSource=$"{imageFolder}expensive/dragon_claw.png",
                    Cost="$188.25",
                    Date="as of Feb. 28, 2024",
                    Description="The claw from a black dragon's left toe. The only piece of the beast that survived an encounter with Pudge's voracious hunger.",
                    Group="Expensive"
                },
                new Cosmetics
                {
                    Name="Bladeform Legacy",
                    ImageSource=$"{imageFolder}arcanas/bladeform_legacy.png",
                    Cost="$26.76",
                    Date="as of Feb. 28, 2024",
                    Description="Yurnero's mask has been cleaved in two, awakening the ancient souls that once laid dormant inside it.",
                    Group="Arcana"
                },
                new Cosmetics
                {
                    Name="Demon Eater",
                    ImageSource=$"{imageFolder}arcanas/demon_eater.png",
                    Cost="$19.25",
                    Date="as of Feb. 28, 2024",
                    Description="Shadow Fiend has long collected the souls of his enemies. As is the case with any collector, some prizes have stood above others, to be sought out at any cost.",
                    Group="Arcana"
                },
                new Cosmetics
                {
                    Name="Great Sage's Reckoning",
                    ImageSource=$"{imageFolder}arcanas/great_sages_reckoning.png",
                    Cost="$24.15",
                    Date="as of Feb. 28, 2024",
                    Description="Though his misdeeds have long been forgiven, the thrills of Sun Wukong's crimes live on. Relive three legendary trials from his earliest adventures with the Great Sage's Reckoning.",
                    Group="Arcana"
                },
                new Cosmetics
                {
                    Name="Manifold Paradox",
                    ImageSource=$"{imageFolder}arcanas/manifold_paradox.png",
                    Cost="$31.10",
                    Date="as of Feb. 28, 2024",
                    Description="With a raspy cackle, the elder smith Craler swung the sword that his family had spent eleven generations to fold and forge. So sharp it was that, with a sound like tearing fabric, a rip in reality tore open.",
                    Group="Arcana"
                },
                new Cosmetics
                {
                    Name="Tempest Helm of Thundergod",
                    ImageSource=$"{imageFolder}arcanas/tempest_helm_of_thundergod.png",
                    Cost="$30.73",
                    Date="as of Feb. 28, 2024",
                    Description="Forged by the Hammers of Celestarr and imbued with the energies of the Ancients, this mighty helm feels at home resting across the brow of the Lord of Heaven himself.",
                    Group="Arcana"
                },
                new Cosmetics
                {
                    Name="Acolyte of the lost Arts",
                    ImageSource=$"{imageFolder}personas/acolyte_of_the_lost_artsr.png",
                    Cost="Battle Pass Exclusive",
                    Date="Battle Pass 2019",
                    Description="International 2019 Battle Pass to level 305 reward.",
                    Group="Persona"
                },
                new Cosmetics
                {
                    Name="Conduit of Blueheart",
                    ImageSource=$"{imageFolder}personas/conduit_of_blueheart.png",
                    Cost="Battle Pass Exclusive",
                    Date="Battle Pass 2022",
                    Description="International 2022 level 148 reward.",
                    Group="Persona"
                },
                new Cosmetics
                {
                    Name="Davion of Dragon Hold",
                    ImageSource=$"{imageFolder}personas/davion_of_dragon_hold.png",
                    Cost="Battle Pass Exclusive",
                    Date="Nemestic Battle Pass",
                    Description="Nemestic Battle Pass level 195 reward.",
                    Group="Persona"
                },
                new Cosmetics
                {
                    Name="Disciples Path",
                    ImageSource=$"{imageFolder}personas/disciples_path.png",
                    Cost="Battle Pass Exclusive",
                    Date="Battle Pass 2020",
                    Description="International Battle Pass level 305 reward.",
                    Group="Persona"
                },
                new Cosmetics
                {
                    Name="The Toy Butcher",
                    ImageSource=$"{imageFolder}personas/the_toy_butcher.png",
                    Cost="Battle Pass Exclusive",
                    Date="Battle Pass 2020",
                    Description="International Battle Pass level 255 reward.",
                    Group="Persona"
                },
                new Cosmetics
                {
                    Name="Aspect of Oscilla",
                    ImageSource=$"{imageFolder}immortals/aspect_of_oscilla.png",
                    Cost="$0.15",
                    Date="as of Feb. 28, 2024",
                    Description="Though the Orbs of Oscilla had garnered intense study and spurred divisive debate spanning entire epochs of arcane methodology.",
                    Group="Immortal"
                },
                new Cosmetics
                {
                    Name="Claws of Nuranu",
                    ImageSource=$"{imageFolder}immortals/claws_of_nuranu.png",
                    Cost="$0.05",
                    Date="as of Feb. 28, 2024",
                    Description="Lacking in comrades and counsel, when Sylla walks an uncertain path, he prays to the memory of Nuranu, most honored of his Bear Clan ancestors--well though he knows a memory is all Nuranu's advice can ever be.",
                    Group="Immortal"
                },
                new Cosmetics
                {
                    Name="Draca Mane",
                    ImageSource=$"{imageFolder}immortals/draca_mane.png",
                    Cost="$0.03",
                    Date="as of Feb. 28, 2024",
                    Description="When exposed to the low pressures of the surface realms, the secretions of a draca eel produce fierce flame without end.",
                    Group="Immortal"
                },
                new Cosmetics
                {
                    Name="Emerald Subjugation",
                    ImageSource=$"{imageFolder}immortals/emerald_subjugation.png",
                    Cost="$0.09",
                    Date="as of Feb. 28, 2024",
                    Description="After selecting the most prized blade from the armory of his conquered foes, Vrogros relegated the rest of their weapons to oblivion, save the double edges of the royal executioner's axe, which the Underlord thought amusing to affix to a new crown.",
                    Group="Immortal"
                },
                new Cosmetics
                {
                    Name="Vigil Odyssey",
                    ImageSource=$"{imageFolder}immortals/vigil_odyssey.png",
                    Cost="$0.11",
                    Date="as of Feb. 28, 2024",
                    Description="Though he spurns their company and their cause, a small band of Vigil-in-exile have sworn allegiance to Sven -- their \"Rogue Commander\" -- and seek to use what little influence they still possess to return to the Vigil Keep and take control of the remnants of the waning order.",
                    Group="Immortal"
                },
            };

            var groupedCosmetics = cosmeticList.GroupBy(cosmetic => cosmetic.Group).ToDictionary(
                group => group.Key,
                group => group.ToList()
            );

            return View(groupedCosmetics);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
