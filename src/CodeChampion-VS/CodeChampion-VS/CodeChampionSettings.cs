using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChampion_VS
{
    public class CodeChampionSettings : DialogPage
    {

        [Category("CodeChampion Settings")]
        [DisplayName("✌️ Epic Victory")]
        [Description("Epic Victory Sound")]
        public VictorySound EpicVictorySound
        {
            get;set;
        }

        [Category("CodeChampion Settings")]
        [DisplayName("💩 Epic Fail")]
        [Description("Epic Fail Sound")]
        public FailSound EpicFailSound
        {
            get; set;
        }



        public enum VictorySound
        {
            [Description("sonic_the_hedgehog_act_cleared.wav")]
            SonicTheHedgehog,
            [Description("supermariobros_stage_clear.wav")]
            SuperMarioBros,
            [Description("duck_hunt_theme.wav")]
            DuckHunt,
            [Description("mk_finish_him.wav")]
            MortalKombat_FinishHim,
            [Description("mk_flawless_victory.wav")]
            MortalKombat_FlawlessVictory,
            [Description("mk_laugh.wav")]
            MortalKombat_HaHaHa,
            [Description("mitokomon.wav")]
            Mitokomon,
            [Description("this_is_sparta.wav")]
            SPARTA,
            [Description("starwars_theme.wav")]
            StarWars,
            [Description("eye_of_tiger.wav")]
            EyeOfTiger,
            [Description("we_will_rock_you.wav")]
            WeWillRockYou,
            [Description("gangnam_style.wav")]
            GangnamStyle,
            [Description("battle_without_honor_or_humanity.wav")]
            KillBill,
            [Description("livin_la_vida_loca.wav")]
            LivinLaVidaLoca,
            [Description("la_copa_de_lavida.wav")]
            LaCopaDeLavida,
            [Description("o_fortuna.wav")]
            OFortuna,
            [Description("symphony_n5.wav")]
            SymphonyN5,
            [Description("iran_national_anthem.wav")]
            IranNationalAnthem,
            [Description("mellipoushan.wav")]
            Mellipoushan
        }


        public enum FailSound
        {
            [Description("supermariobros_gameover.wav")]
            SuperMarioBros,
            [Description("duck_hunt_laugh.wav")]
            DuckHunt,
            [Description("homer_you_tried.wav")]
            HomerSimpson,
            [Description("pulp_fiction_say_what_again.wav")]
            PulpFiction,
            [Description("darth_vader_dont_fail_me.wav")]
            DarthVader,
            [Description("voldemort_your_a_fool.wav")]
            LordVoldemort,
            [Description("arrow_you_have_failed.wav")]
            Arrow,
            [Description("a_lannister_always_pays_his_debts.wav")]
            GOT,
            [Description("chop_suey.wav")]
            ChopSuey,
            [Description("someone_like_you.wav")]
            Adele
        }
    }
}
