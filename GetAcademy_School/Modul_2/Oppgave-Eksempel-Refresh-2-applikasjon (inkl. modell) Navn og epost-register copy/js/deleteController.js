// her er stedet som objektet i arrayet model.people skal slettes: slettes med splice, men vi trenger å vite indexen i arrayet som skal slettes.
function deletePerson() {
    if(!model.inputs.delete.sureOrNotCheck) return; // hvis sureOrNotCheck er "false" return og avslutt.(forsøk på å trykke på "slett knappen fører til ingenting")
    const index = findPersonIndexById(model.inputs.delete.personId) // 
    model.people.splice(index, 1)
    model.app.currentPage = 'search' // setter tilbake til 'search, slik at vik kan se resultatet (listen) av det som er blitt gjort.(slettet)
    console.log(index);
    updateView() 

}