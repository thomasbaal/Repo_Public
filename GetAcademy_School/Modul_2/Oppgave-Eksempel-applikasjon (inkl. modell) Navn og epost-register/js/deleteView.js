function updateViewDelete() {
    console.log('Entering deleteView');
    document.getElementById("emailApp").innerHTML = /*html*/ `
    ${createMenuHtml()} 
    <hr/>
    <h3>Slett</h3>
    <input type="Checkbox"/>Er du sikker på at du vil slette?<br/>
    <button>Slett!</button>
    `;
}

function createPersonHtml() {
    const personId = model.inputs.delete.personId
    const person = findPersonById(personId);
    return /*html*/ `
    <label>Navn</label>
    ${person.name} <br/>
    <label>Epost</label>
    ${person.email}<br/>
    
    `
}