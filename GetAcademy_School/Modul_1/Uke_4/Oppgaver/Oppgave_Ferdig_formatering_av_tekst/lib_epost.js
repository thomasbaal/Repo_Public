// function checkEmail(text) {
//     let trueOrFalse = text.includes('@');
//     console.log(trueOrFalse);
//     return trueOrFalse

//     // return trimmedText.charAt(0).toUpperCase() + trimmedText.slice(1).toLowerCase();
// }; // returnerer trimmet tekst at characer 0 = t .toupperCase setter t til stor T. + slice ved position 1. to lowercase.

// function checkIfSpaces(text) {
//     let trimmedText = text.trim()
//     return trimmedText
// }


// function addPunctuation(text) {
//     let checkIfGotAlpha = text.includes('@');
//     if (checkIfGotAlpha == true) { gotAlphaPosition = text.indexOf('@') }
//     // charBeforeAlpha = gotAlphaPosition - 1
//     // charAfterAlpha = gotAlphaPosition + 1

//     var sliceBeforeAlpha = text.slice(0, gotAlphaPosition)
//     var sliceAfterAlpha = text.slice(gotAlphaPosition + 1)
//     var addAll = sliceBeforeAlpha + '.' + '@' + '.' + sliceAfterAlpha
//     console.log(addAll);
//     return addAll
// }

function doItAll(text) {
    let checkIfGotAlpha = text.includes('@');
    if(checkIfGotAlpha = true) {
        gotAlphaPosition = text.indexOf('@') 
        var sliceBeforeAlpha = text.slice(0, gotAlphaPosition)
        var sliceAfterAlpha = text.slice(gotAlphaPosition + 1)
        var addAll = sliceBeforeAlpha + '.' + '@' + '.' + sliceAfterAlpha
        return addAll.trim()
        
    }



    // fix spaces.
    // let trimmedText = text.trim()
    // add punctuation.


}




// let trimmedText = text.trim() // fjerner mellomrom..