function fixText(text) {
    let trimmedText = text.trim() // fjerner mellomrom..
    return trimmedText.charAt(0).toUpperCase() + trimmedText.slice(1).toLowerCase();
}; // returnerer trimmet tekst at characer 0 = t .toupperCase setter t til stor T. + slice ved position 1. to lowercase.




