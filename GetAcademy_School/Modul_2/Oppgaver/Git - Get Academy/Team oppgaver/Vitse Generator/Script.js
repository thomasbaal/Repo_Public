// --------------------------------------------------------------------------------------------        
/************************************Shuffle****************************************/
/*


// function sufflé(array) {
    let curly = array.length;

    // Det ligger igjen elementer å shuffle
    while (0 !== curly) {
        // Velg et gjenliggende element
        let randID = Math. floor(Math.random() * CurlyID);
        curly -= 1;
        // Bytt ut med det nåværende elementet
        let tmp =array[randID];
        array[randID] = tmp;
        return array;
        // Selve bruken av Shuffle
        let vits = ["hoho", "haha"];
        arr = shuffleArray(arr);
        console.log(arr);
    }
}



*/
// ------------------------------------------------------------------------
let colors = 'AliceBlue,AntiqueWhite,Aqua,Aquamarine,Azure,Beige,Bisque,Black,BlanchedAlmond,Blue,BlueViolet,Brown,BurlyWood,CadetBlue,Chartreuse,Chocolate,Coral,CornflowerBlue,Cornsilk,Crimson,Cyan,DarkBlue,DarkCyan,DarkGoldenrod,DarkGray,DarkGreen,DarkGrey,DarkKhaki,DarkMagenta,DarkOliveGreen,DarkOrange,DarkOrchid,DarkRed,DarkSalmon,DarkSeaGreen,DarkSlateBlue,DarkSlateGray,DarkSlateGrey,DarkTurquoise,DarkViolet,DeepPink,DeepSkyBlue,DimGray,DodgerBlue,FireBrick,FloralWhite,ForestGreen,Fuchsia,Gainsboro,GhostWhite,Gold,Goldenrod,Gray,Green,GreenYellow,Grey,Honeydew,HotPink,IndianRed,Indigo,Ivory,Khaki,Lavender,LavenderBlush,LawnGreen,LemonChiffon,LightBlue,LightCoral,LightCyan,LightGoldenrodYellow,LightGray,LightGreen,LightGrey,LightPink,LightSalmon,LightSeaGreen,LightSkyBlue,LightSlateGray,LightSlateGrey,LightSteelBlue,LightYellow,Lime,LimeGreen,Linen,Magenta,Maroon,MediumAquamarine,MediumBlue,MediumOrchid,MediumPurple,MediumSeaGreen,MediumSlateBlue,MediumSpringGreen,MediumTurquoise,MediumVioletRed,MidnightBlue,MintCream,MistyRose,Moccasin,NavajoWhite,Navy,OldLace,Olive,OliveDrab,Orange,OrangeRed,Orchid,PaleGoldenrod,PaleGreen,PaleTurquoise,PaleVioletRed,PapayaWhip,PeachPuff,Peru,Pink,Plum,PowderBlue,Purple,Rebeccapurple,Red,RosyBrown,RoyalBlue,SaddleBrown,Salmon,SandyBrown,SeaGreen,Seashell,Sienna,Silver,SkyBlue,SlateBlue,SlateGray,SlateGrey,Snow,SpringGreen,SteelBlue,Tan,Teal,Thistle,Tomato,Turquoise,Violet,Wheat,White,WhiteSmoke,Yellow,YellowGreen'

        let cssColors = colors.split(',');
        console.log(cssColors[3]);
        console.log(cssColors[7]);

        let random = Math.floor(Math.random() * cssColors.length);
        let randomCssColor = cssColors[random];
        document.getElementById("randomJokesDiv").style.color = randomCssColor;
// --------------------------------------------------------------------------
let vitser = 
        [`Why did the programmer quit his job?
        Because he didn't get arrays.`,
        
        `Why did the CSS major quit his job?
        He didn't get arrays.`,

        `An optimist says 'The glass is half full.'
        A pessimist says 'The glass is half empty.'
        A programmer says 'The glass is twice as large as necessary.'`,

        `A programmer puts two glasses on his bedside table before going to sleep. 
        A full one, in case he gets thirsty, and an empty one, in case he doesn't.`,

        `Why do Java programmers have to wear glasses?
        Because they don't C#.`,

        `!false
        (It's funny because it's true.)`
        
        ]
let randomJokes = vitser[Math.floor(Math.random() * vitser.length)];

showRandomJoke();

function showRandomJoke() {
    document.getElementById('randomJokesDiv').innerHTML = randomJokes;
                            
}



// for(i = 0; i < vitser.length; i++) {
    
// };