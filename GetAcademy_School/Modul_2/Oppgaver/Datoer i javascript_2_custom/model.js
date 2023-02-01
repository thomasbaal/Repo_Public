const model = {

    app: {
        currentPage: 'taskView',
        isAdmin: false,
        currentUser: 'Thomas',
    },

    inputs: {
        taskDescription: '',
        taskResponsible: '',
        taskAdded: '',
    },

    users: [
        {id: '', userName: 'Thomas', passWord: '123', starCount: 0},
        {id: '', userName: 'Liam', passWord: '234', starCount: 0},
    ],

    tasks: [
       
            {id: '', description: 'Spille Death Stranding', responsible: 'Thomas', taskAdded: '2022.08.22', taskCompleted: '2022.08.24', isDone: false, editMode: false},
            {id: '', description: 'Vaske kjøkkenet', responsible: 'Thomas', taskAdded: '2022.08.22', taskCompleted: '2022.08.24', isDone: false, editMode: false},

        
    ]

}

