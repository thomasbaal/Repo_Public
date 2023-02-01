function goToOptionsPage() {
    model.app.currentPage = 'addOptionPage'
    updateView()
}

function vote(index) {
    // voteCount eksisterer ikke , så det settes her nå.
    let option = model.options[index];
    if(!option.voteCount) { // 1.hvis votecount ikke fins
        option.voteCount = 0; // 2.lag og sett voteCount til 0
        
    }
    option.voteCount++; 
    updateView()
}