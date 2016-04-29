using FindMyMain.Model.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FindMyMain.AnswersEngine
{
    public class AnswersEngine
    {
        public string Answer(KnownChampion selectedChampion, KnownChampion targetChampion)
        {
            // match
            if (selectedChampion == targetChampion)
                return "Bingo!";

            var selectedChampionDescription = ChampionDescription.GetChampionDescription(selectedChampion);
            var targetChampionDescription = ChampionDescription.GetChampionDescription(targetChampion);

            if (!(selectedChampionDescription.HasValue && targetChampionDescription.HasValue))
                return "unknown champion";

            var selected = selectedChampionDescription.Value;
            var target = targetChampionDescription.Value;

            // special quotes
            var specialQuote = selected.SpecialQuotes[target.Champion];
            if (!string.IsNullOrEmpty(specialQuote))
                return specialQuote;

            // similarities

            List<string> similaritesAnswers = new List<string>();

            var sameRoleAnswer = SameRoleAnswer(selected, target);
            if (!string.IsNullOrEmpty(sameRoleAnswer)) similaritesAnswers.Add(sameRoleAnswer);

            var sameRegionAnswer = SameRegionAnswer(selected, target);
            if (!string.IsNullOrEmpty(sameRegionAnswer)) similaritesAnswers.Add(sameRegionAnswer);

            var samePerkAnswer = SamePerkAnswer(selected, target);
            if (!string.IsNullOrEmpty(samePerkAnswer)) similaritesAnswers.Add(samePerkAnswer);

            var sameSkinAnswer = SameSkinAnswer(selected, target);
            if (!string.IsNullOrEmpty(sameSkinAnswer)) similaritesAnswers.Add(sameSkinAnswer);

            // prepare answer, based on number of similarities
            StringBuilder answerBuilder = new StringBuilder();
            answerBuilder.Append(selected.WelcomeQuote);

            switch (similaritesAnswers.Count)
            {
                case 0:
                    answerBuilder.Append("Looks like I dont have much in common with a champion you are looking for...");
                    break;
                case 1:
                    answerBuilder.Append("I got something in common with a champion you are looking for - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    break;
                case 2:
                    answerBuilder.Append("I got matching points with a champion you are looking for - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    answerBuilder.Append(" and ");
                    answerBuilder.Append(similaritesAnswers[1]);
                    break;
                case 3:
                    answerBuilder.Append("Champion you are looking for is quite like me - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    answerBuilder.Append(" and ");
                    answerBuilder.Append(similaritesAnswers[1]);
                    answerBuilder.Append(" also ");
                    answerBuilder.Append(similaritesAnswers[2]);
                    break;
                case 4:
                    answerBuilder.Append("Incredible! So much similarities - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    answerBuilder.Append(" and ");
                    answerBuilder.Append(similaritesAnswers[1]);
                    answerBuilder.Append(" also ");
                    answerBuilder.Append(similaritesAnswers[2]);
                    answerBuilder.Append(" and ");
                    answerBuilder.Append(similaritesAnswers[3]);
                    break;
                default:
                    break;
            }

            return answerBuilder.ToString();
        }

        // Private methods

        private string SameRoleAnswer(ChampionDescription selected, ChampionDescription target)
        {
            if (selected.Role != target.Role) return null;

            switch (selected.Role)
            {
                case RoleTag.Tank:
                    return "Tank";
                case RoleTag.Fighter:
                    return "Fighter";
                case RoleTag.Slayer:
                    return "Slayer";
                case RoleTag.Mage:
                    return "Mage";
                case RoleTag.Controller:
                    return "Controller";
                case RoleTag.Marksmen:
                    return "Marksmen";
                default:
                    return null;
            }
        }

        private string SameRegionAnswer(ChampionDescription selected, ChampionDescription target)
        {
            if (selected.Region != target.Region) return null;

            switch (selected.Region)
            {
                case RegionTag.BandleCity:
                    return "BandleCity";
                case RegionTag.Bilgewater:
                    return "Bilgewater";
                case RegionTag.Damacia:
                    return "Damacia";
                case RegionTag.Freljord:
                    return "Freljord";
                case RegionTag.Ionia:
                    return "Ionia";
                case RegionTag.MountTargon:
                    return "MountTargon";
                case RegionTag.Noxus:
                    return "Noxus";
                case RegionTag.Piltover:
                    return "Piltover";
                case RegionTag.ShadowIsles:
                    return "ShadowIsles";
                case RegionTag.Shurima:
                    return "Shurima";
                case RegionTag.Zaun:
                    return "Zaun";
                case RegionTag.Void:
                    return "Void";
                case RegionTag.Other:
                    return "Other";
                default:
                    return null;
            }
        }

        private string SamePerkAnswer(ChampionDescription selected, ChampionDescription target)
        {
            var commonPerks = selected.Perks.Intersect(target.Perks);
            if (commonPerks.Count() == 0) return null;
            else
            {
                var commonPerk = commonPerks.First();

                switch (commonPerk)
                {
                    case PerkTag.Animal:
                        return "we are both influenced by animal soul";
                    case PerkTag.Shapeshifter:
                        return "we can adopt - change ourselfs depending on circumstances";
                    case PerkTag.PetChampion:
                        return "we both have beings that aid us in a fight";
                    case PerkTag.HealthCostAbilities:
                        return "in fight we pay with own blood!";
                    case PerkTag.Global:
                        return "we can help our allies and punish enemies from vast distance";
                    case PerkTag.Yordle:
                        return "we are both a Yordle, to some degree at last";
                    default:
                        return null;
                }
            }
        }

        private string SameSkinAnswer(ChampionDescription selected, ChampionDescription target)
        {
            var commonSkins = selected.Skins.Intersect(target.Skins);
            if (commonSkins.Count() == 0) return null;
            else
            {
                var commonSkin = commonSkins.First();
                var stringifiedCommonSkin = Enum.GetName(typeof(SkinTag), commonSkin);
                
                return $"sometimes we both fight in Runterra in {stringifiedCommonSkin} outfit";
            }
        }
    }
}