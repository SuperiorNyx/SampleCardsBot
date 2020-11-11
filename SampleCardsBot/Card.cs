using System.Collections.Generic;
using System.IO;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace SampleCardsBot
{
    public static class Card
    {
        public static HeroCard GetSeattleCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Seattle, Washington",
                Text = "Seattle is a seaport city on the West Coast of the United States."+
                        " It is the seat of King County, Washington. Seattle is the largest city in both the state of Washington and in the Pacific Northwest"+
                        " region of North America.",
                Images = new List<CardImage> { new CardImage("https://upload.wikimedia.org/wikipedia/commons/e/e3/Seattle_Kerry_Park_Skyline.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Seattle") },
            };

            return heroCard;
        }

        public static HeroCard GetTokyoCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Tokyo, Japan",
                Text = "Tokyo, officially Tokyo Metropolis (東京都, Tōkyō-to), is the capital and most populous prefecture of Japan."+
                " Located at the head of Tokyo Bay, the prefecture forms part of the Kantō region on the central Pacific coast of Japan's main island of Honshu.",
                Images = new List<CardImage> { new CardImage("https://static1.squarespace.com/static/53787978e4b02899e92292a5/537886cee4b0e8c9b2ae9907/59401a90db29d6d9789077f6/1497884404028/thumb_IMG_0690_1024.jpg?format=1500w") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Tokyo") },
            };

            return heroCard;
        }

        public static HeroCard GetNewDelhiCard()
        {
            var heroCard = new HeroCard
            {
                Title = "New Delhi, India",
                Text = "New Delhi is the capital of India and an administrative district of NCT Delhi. "+
                "New Delhi is also the seat of all three branches of the government of India, hosting the Rashtrapati Bhavan, Parliament House, and the Supreme Court of India."+
                " Delhi itself is often considered as a hub for international and trade and has been labelled as a global city with its rising economy and wealth.",
                Images = new List<CardImage> { new CardImage("https://static1.squarespace.com/static/53787978e4b02899e92292a5/537886cee4b0e8c9b2ae9907/59401a90db29d6d9789077f6/1497884404028/thumb_IMG_0690_1024.jpg?format=1500w") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/New_Delhi") },
            };

            return heroCard;
        }
        public static HeroCard GetManilaCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Manila, Philippines",
                Text = "Manila, officially the City of Manila (Filipino: Lungsod ng Maynilà), is the capital of the Philippines and a highly urbanized city."+
                " It is the most densely populated city proper in the world as of 2019.",
                Images = new List<CardImage> { new CardImage("https://media-cdn.tripadvisor.com/media/photo-c/1024x250/12/1e/3b/f5/photo8jpg.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Manila") },
            };

            return heroCard;
        }

        public static HeroCard GetNewYorkCard()
        {
            var heroCard = new HeroCard
            {
                Title = "New York City, New York",
                Text = "New York City (NYC), often called simply New York, is the most populous city in the United States."+
                " With an estimated 2019 population of 8,336,817 distributed over about 302.6 square miles (784 km2),"+
                " New York City is also the most densely populated major city in the United States.",
                Images = new List<CardImage> { new CardImage("https://upload.wikimedia.org/wikipedia/commons/4/47/New_york_times_square-terabass.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/New_York_City") },
            };

            return heroCard;
        }

        public static HeroCard GetLondonCard()
        {
            var heroCard = new HeroCard
            {
                Title = "London, England",
                Text = "Tokyo, officially Tokyo Metropolis (東京都, Tōkyō-to), is the capital and most populous prefecture of Japan." +
                " Located at the head of Tokyo Bay, the prefecture forms part of the Kantō region on the central Pacific coast of Japan's main island of Honshu.",
                Images = new List<CardImage> { new CardImage("https://commons.wikimedia.org/wiki/File:Tokyo_Tower_and_surrounding_area.jpg#/media/File:Tokyo_Tower_and_surrounding_area.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Tokyo") },
            };

            return heroCard;
        }

        public static HeroCard GetJohannesburgCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Johannesburg, South Africa",
                Text = "Tokyo, officially Tokyo Metropolis (東京都, Tōkyō-to), is the capital and most populous prefecture of Japan." +
                " Located at the head of Tokyo Bay, the prefecture forms part of the Kantō region on the central Pacific coast of Japan's main island of Honshu.",
                Images = new List<CardImage> { new CardImage("https://commons.wikimedia.org/wiki/File:Tokyo_Tower_and_surrounding_area.jpg#/media/File:Tokyo_Tower_and_surrounding_area.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Tokyo") },
            };

            return heroCard;
        }

        public static HeroCard GetBeijingCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Beijing, China",
                Text = "Tokyo, officially Tokyo Metropolis (東京都, Tōkyō-to), is the capital and most populous prefecture of Japan." +
                " Located at the head of Tokyo Bay, the prefecture forms part of the Kantō region on the central Pacific coast of Japan's main island of Honshu.",
                Images = new List<CardImage> { new CardImage("https://commons.wikimedia.org/wiki/File:Tokyo_Tower_and_surrounding_area.jpg#/media/File:Tokyo_Tower_and_surrounding_area.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Tokyo") },
            };

            return heroCard;
        }

        public static HeroCard GetMexicoCityCard()
        {
            var heroCard = new HeroCard
            {
                Title = "Mexico City, Mexico",
                Text = "Tokyo, officially Tokyo Metropolis (東京都, Tōkyō-to), is the capital and most populous prefecture of Japan." +
                " Located at the head of Tokyo Bay, the prefecture forms part of the Kantō region on the central Pacific coast of Japan's main island of Honshu.",
                Images = new List<CardImage> { new CardImage("https://commons.wikimedia.org/wiki/File:Tokyo_Tower_and_surrounding_area.jpg#/media/File:Tokyo_Tower_and_surrounding_area.jpg") },
                Buttons = new List<CardAction> { new CardAction(ActionTypes.OpenUrl, "Learn More", value: "https://en.wikipedia.org/wiki/Tokyo") },
            };

            return heroCard;
        }

    }
}
