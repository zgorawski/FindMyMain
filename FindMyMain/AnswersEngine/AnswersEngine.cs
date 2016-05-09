using FindMyMain.Model.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FindMyMain.AnswersEngineNamespace
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
            if (selected.SpecialQuotes != null && selected.SpecialQuotes.ContainsKey(target.Champion))
                return selected.SpecialQuotes[target.Champion];

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

            // TODO: introduce better welcome quotes
            // answerBuilder.Append(selected.WelcomeQuote);
            // answerBuilder.Append(Environment.NewLine);

            switch (similaritesAnswers.Count)
            {
                case 0:
                    answerBuilder.Append("Looks like I don't have much in common with the champion you are looking for...");
                    break;
                case 1:
                    answerBuilder.Append("I have something in common with the champion you are looking for - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    break;
                case 2:
                    answerBuilder.Append("I have some matching points with the champion you are looking for - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    answerBuilder.Append(" and ");
                    answerBuilder.Append(similaritesAnswers[1]);
                    break;
                case 3:
                    answerBuilder.Append("The champion you are looking for is quite like me - ");
                    answerBuilder.Append(similaritesAnswers[0]);
                    answerBuilder.Append(" and ");
                    answerBuilder.Append(similaritesAnswers[1]);
                    answerBuilder.Append(" also ");
                    answerBuilder.Append(similaritesAnswers[2]);
                    break;
                case 4:
                    answerBuilder.Append("Incredible! So many similarities - ");
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
                    return "We are the first to enter the battle and the last to leave";
                case RoleTag.Fighter:
                    return "We are fighters, duh..";
                case RoleTag.Slayer:
                    return "We spot weakness and eliminate it";
                case RoleTag.Mage:
                    return "We don't get dirty - we let the magic do the work";
                case RoleTag.Controller:
                    return "Protecting allies, disturbing enemies - that's what we are best at";
                case RoleTag.Marksmen:
                    return "We both like to throw, shoot and keep our distance";
                default:
                    return null;
            }
        }

        private string SameRegionAnswer(ChampionDescription selected, ChampionDescription target)
        {
            if (selected.Region != target.Region) return null;

            if (selected.Region == RegionTag.Other)
            {
                return "we are both from unique places";
            }
            else
            {
                var region = RegionTagUtility.Stringify(selected.Region);
                return ((int)selected.Region % 2 == 1) ? "we are now in or have been to " + region : "we both have visited " + region;
            }            
        }

        private string SamePerkAnswer(ChampionDescription selected, ChampionDescription target)
        {
            if (selected.Perks == null || target.Perks == null) return null;

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
                        return "we can adapt - change ourselves depending on the circumstances";
                    case PerkTag.PetChampion:
                        return "we both have beings that aid us in a fight";
                    case PerkTag.HealthCostAbilities:
                        return "in a fight we pay with our own blood!";
                    case PerkTag.Global:
                        return "we can help our allies and punish enemies from a huge distance";
                    case PerkTag.Yordle:
                        return "we both are Yordles, at least to some degree";
                    default:
                        return null;
                }
            }
        }

        private string SameSkinAnswer(ChampionDescription selected, ChampionDescription target)
        {
            if (selected.Skins == null || target.Skins == null) return null;

            var commonSkins = selected.Skins.Intersect(target.Skins);
            if (commonSkins.Count() == 0) return null;
            else
            {
                var commonSkin = commonSkins.First();
                var skinText = SkinTagUtility.Stringify(commonSkin);

                return ((int)commonSkin % 2 == 1) ? "sometimes we both fight in Runterra in " + skinText + " outfit" : "We find " + skinText + " outfit very stylish";
            }
        }
    }
}