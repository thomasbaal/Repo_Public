const model = {
    // Tilstand
    app: {
        currentPage: 'search', // createNew, delete, edit
    },


    // inputs
    inputs: {
        search: {
            text: '',
        },

        createNew: {
            name: '',
            emailAddress: '',
        },

        delete: {
            sureOrNotCheck: false,
            personId: null,
        },
        edit: {
            name: '',
            email: '',
            personId: null,
        },
    },
    // Felles data

    people: [
        {id:1, name: 'Per', email: 'per@hotmail.com', },
        {id:2, name: 'Thomas', email: 'thomas79@gmail.com' },
        {id:3, name: 'Pål', email: 'pål@live.com', },
        {id:4, name: 'Andrea', email: 'andreabravor@hotmail.com', },
        {id:5, name: 'Marian', email: 'marian@crazynet.com', },




   ]
        


}