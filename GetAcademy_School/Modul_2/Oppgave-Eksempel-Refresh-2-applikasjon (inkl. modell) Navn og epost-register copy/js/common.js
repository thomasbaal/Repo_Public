function createMenuHtml() {
    return /*html*/ `
    <button onclick="model.app.currentPage='search'; updateView()">Søk</button>
    <button onclick="model.app.currentPage='createNew'; updateView()">Legge til</button>
    `;
}

function findPersonById(personId) {
    for(let person of model.people) {
        if(person.id === personId) return person
            
         
    }
    return null;
}

function findPersonIndexById(personId) {
    for(let i = 0; i < model.people.length; i++) {
        let person = model.people[i];
        if(person.id === personId ) {
            return i;
        }else {return null;}
    

    }
}