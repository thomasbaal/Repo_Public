function fixText(txt) {
    // return txt.charAt(0).toUpperCase() + txt.slice(1)
        // return txt.trim().charAt(0).toUpperCase() + txt.slice(1)
        let tempTxt = txt.trim()
        return tempTxt.charAt(0).toUpperCase() + tempTxt.slice(1)
    // console.log(txt.charAt(0).toUpperCase() + txt.slice(1));
    
}