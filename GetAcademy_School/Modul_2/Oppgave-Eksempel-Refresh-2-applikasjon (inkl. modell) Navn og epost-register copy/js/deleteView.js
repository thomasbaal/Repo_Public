function updateViewDelete() {
    console.log('Switched to deleteView');
    // her skal man en checkbox (sikker på at du vil slette ? )
    // trenger å vite hvem vi skal slette: dette vet vi da dette ble skrevet inn i modellen tidligere. (model.inputs.delete.personId)
    // så man henter id fra modellen fremfor å sende det med parameteret.
    
    // NOTE! - Dette er en side som kun vises som en "er du sikker på at du vil slette side."
    document.getElementById("registerApp").innerHTML = /*html*/ `
    
    ${createMenuHtml()}
    <hr>
    ${createPersonDeleteHtml()} 
    <h3>Slett</h3>
    <input 
    type="checkbox"
    oninput="model.inputs.delete.sureOrNotCheck=this.checked"
    ${model.inputs.delete.sureOrNotCheck ? 'checked' : ''}
    />Er du sikker på at du vil slette ?<br/>
    <button onclick="deletePerson()">Slett !</button>
    
    `
}

function createPersonDeleteHtml() {
    // henter opp id og lagrer til variabel.
    const personId = model.inputs.delete.personId;
    // sender parameter til en "find funksjon" som er lagret i common.js
    let person = findPersonById(personId);
    console.log(person);

    // findPersonById funksjonen finner å lagrer dette i variabelen person.
    // under returner vi med resultatet som ble funnet å lagret i  person tilbake til kalleren.

    return /*html*/ `
        Navn: ${person.name} <br/>
        Epost: ${person.email} <br/>
    `


}