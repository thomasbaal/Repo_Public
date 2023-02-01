function updateViewSearch() {
    console.log('Switched to searchView');
    const searchText = model.inputs.search.text;    
    document.getElementById("registerApp").innerHTML = /*html*/ `
    ${createMenuHtml()}
    <hr>
        <h3>Søk</h3>
        <input type="text" oninput="model.inputs.editNewUser.userName=this.value" > Brukernavn: <br>

        <input oninput="model.inputs.search.text=this.value" value="${searchText}" placeholder="Søk navn eller epost" type="text" />
        <button onclick="updateView()" >Søk</button>
        <hr>
        <h4>Søkeresultater</h4>
        
        <hr>
        <ul>
            ${createHtmlPeople()}
        </ul>
    `;
} 

function createHtmlPeople() {
    let htmlPeople = '';
    const searchText = model.inputs.search.text;
    let people = model.people;
    console.log(people);
    // let filtered = '';
        if(searchText !== '') {
            people = filteredPeople(searchText); // filtrer og returner samt lagret i variabelen "people"
            console.log(people); // søk med "å" gives pål , dvs den returnerer riktig

        }   
         for(let i = 0; i < people.length; i++) {
            const person = people[i];        
            htmlPeople += `
            <li>Navn: ${person.name}</li>
            <li>Epost: ${person.email} <button data-id="${i}" onclick="goToDeletePage(${person.id})">X</button>
            <button onclick="goToEditPage(${person.id})">Rediger</button>
            </li>  
            
            <hr>
            `

        }
        
        // console.log(htmlPeople);
    return htmlPeople

}


function filteredPeople(searchText) {
    searchText = searchText.toLowerCase();
        // ny liste
        let arrFilteredPeople = [];
        for(let person of model.people) { 
            // console.log(person);// {id: 1, name: 'Per', email: 'per@mail.com'} E.T.C !
            const name = person.name.toLowerCase()
            const email = person.email.toLowerCase()
            // console.log(name); // per, pål, espen o.s.v
            if(name.indexOf(searchText) != -1 || email.indexOf(searchText) != -1) {
                arrFilteredPeople.push(person)
            }  

            console.log(arrFilteredPeople);
        }
   return arrFilteredPeople
}    