function updateViewSearch() {
    const searchText = model.inputs.search.text

    console.log('Entering searchView');
    document.getElementById("emailApp").innerHTML = /*html*/ `
    ${createMenuHtml()} 
    <hr/>
    <h3>Søk</h3>
    <input 
        type="text" 
        oninput="model.inputs.search.text=this.value"
        value="${searchText || ''}"
    />
    <button>Søk</button> <br/>
    
    <h4>Søkeresultater:</h4>
    <ul>
        ${createHtmlPeople()}
    </ul>
    `;

    function createHtmlPeople() {
        let htmlPeople = '';
        let people = model.people;
        let searchText = model.inputs.search.text
       if(searchText !== '') {
            people = filterPeople(searchText, people);
       }
       
        for(let i = 0; i < people.length; i++) {
            const person = people[i]
            // console.log(people[i]);

            // Note!: under - person.id settes i model objektet, slikt at man senere plukker ut riktig!!.
            htmlPeople += `
            <li>${person.name}
                ${person.email}
                <button onclick="goToDeletePage(${person.id})">X</button>
            <li/>
            `;
            console.log(person.id);
        }

        return htmlPeople; 
    }


    function filterPeople(searchText, people) {
        searchText = searchText.toLowerCase();
        // ny liste
        let filteredList = [];
        for(let person of people) { 
            console.log(person);// {id: 1, name: 'Per', email: 'per@mail.com'} E.T.C !
            const name = person.name.toLowerCase()
            const email = person.email.toLowerCase()
            console.log(name); // per, pål, espen o.s.v
            if(name.indexOf(searchText) != -1 || email.indexOf(searchText) != -1) {
                filteredList.push(person)
            }  
        }
        // console.log(`----filteredList: filteredList`);
        console.log(filteredList);
        return filteredList;
    }

   
}