// commonView skal være tilgjengelig fra alle sider.(om ønskelig)
// en side som tegner opp html.
// i dette tilfelle blir den kalt opp fra andre sider, returnerer så 
// det som skal bli tegnet opp fra "kalleren."

function createMenuHtml() {
    // meny for å gå til: search,    
    
    return /*html*/ `
        <button onclick="model.app.currentPage = 'search'"; updateView() >søk</button>
        <button onclick="model.app.currentPage = 'createNew'"; updateView() >Legge til</button>
        <div>${counterTest()}</div>
        `
}

function findPersonById(id) {
    for(let person of model.people){
        if(person.id === id) return person;
    }
    return null;
}

function counterTest() {
   let count = model.test.count;
   setInterval(() => {
    count += 5;
   }, 2000);

   

}


// //Find object by id from a liste
// function findObjectById(id, list) {
//     for(let obj of list) {
//         if(obj.id === id)return obj;
//     }
//     return null;
// }   