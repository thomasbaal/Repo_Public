const model = {
    // 1 Tilstanden til appen
    app: {
        currentPage: 'search' // Start verdi, andre verdier kan være: Create new, delete, edit
    },




    // 2 Inputs for alle sider
    inputs: {
        search: {
            text: '',
        },
        createNew: {
            name: '',
            emailAddress: '',
        },
        delete: {
            isAreYouSureChecked: false, // denne må være her da den MÅ OPPDATERES!
            personId: null,
        }

    },



    // 3 Felles data - tilhører ikke bare en side, men mange.
    // korte ned "pathen" til dataene så mye som mulig.
    people: [
        {id: 1, name: 'Per', email: 'per@mail.com'},
        {id: 2, name: 'Pål', email: 'pål@hotmail.com'},
        {id: 3, name: 'Espen', email: 'espen@askeladden.com'},
        {id: 4, name: '', email: 'Ikkeno@amazing.com'},
    ],

    test: {count: 0},
}
