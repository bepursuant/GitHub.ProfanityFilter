﻿using IEvangelist.GitHub.Services.Extensions;
using System.Collections.Generic;

namespace IEvangelist.GitHub.Services.Filters
{
    public class GitHubEmojiWordReplacer : IWordReplacer
    {
        // Borrowed from: https://www.webfx.com/tools/emoji-cheat-sheet/
        internal static ISet<string> Emoji { get; } = new HashSet<string>
        {
            ":rage:",
            ":boom:",
            ":poop:",
            ":cherry_blossom:",
            ":fire:",
            ":facepunch:",
            ":weary:",
            ":laughing:",
            ":octopus:",
            ":hurtrealbad:",
            ":baby:",
            ":baby_bottle:",
            ":warning:",
            ":revolving_hearts:",
            ":see_no_evil:",
            ":snowflake:",
            ":zap:",
            ":ribbon:",
            ":angel:",
            ":monkey:",
            ":bug:",
            ":rose:",
            ":sparkles:",
            ":heartpulse:",
            ":cry:",
            ":floppy_disk:",
            ":question:",
            ":speak_no_evil:",
            ":tada:",
            ":crying_cat_face:",
            ":rage2:",
            ":ok:",
            ":sparkling_heart:",
            ":love_letter:",
            ":scream:",
            ":gift_heart:",
            ":grin:",
            ":hear_no_evil:",
            ":flushed:",
            ":sunflower:",
            ":anguished:",
            ":expressionless:",
            ":cold_sweat:",
            ":triumph:",
            ":confetti_ball:",
            ":toilet:",
            ":disappointed:",
            ":baby_bottle:",
            ":confounded:",
            ":broken_heart:",
            ":exclamation:",
            ":boom:",
            ":fire:",
            ":dancer:",
            ":japanese_goblin:",
            ":stuck_out_tongue_winking_eye:",
            ":cool:",
            ":whale:",
            ":hibiscus:",
            ":rabbit2:",
            ":baby_chick:",
            ":frog:",
            ":dog:",
            ":neckbeard:",
            ":cyclone:"
        };

        public string ReplaceWord(string word) => Emoji.GetRandomElement();
    }
}
