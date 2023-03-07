class TodoListView {
    constructor() {
      this.todosList = document.querySelector('.todos ul');
    }
  
    render(todoList) {
      this.todosList.innerHTML = '';
  
      todoList.todos.forEach((todo, index) => {
        const todoItem = document.createElement('li');
        const todoCheckbox = document.createElement('input');
        const todoText = document.createElement('span');
        const todoDeleteButton = document.createElement('button');
  
        todoCheckbox.type = 'checkbox';
        todoCheckbox
        todoCheckbox.checked = todo.completed;
        todoCheckbox.addEventListener('change', () => {
          if (todoCheckbox.checked) {
            controller.markTodoCompleted(index);
          } else {
            controller.markTodoActive(index);
          }
        });
      
        todoText.innerText = todo.text;
      
        todoDeleteButton.innerText = 'Delete';
        todoDeleteButton.addEventListener('click', () => {
          controller.deleteTodoAtIndex(index);
        });
      
        todoItem.appendChild(todoCheckbox);
        todoItem.appendChild(todoText);
        todoItem.appendChild(todoDeleteButton);
      
        this.todosList.appendChild(todoItem);
      });
      scss
Copy code
  todoCheckbox.checked = todo.completed;
  todoCheckbox.addEventListener('change', () => {
    if (todoCheckbox.checked) {
      controller.markTodoCompleted(index);
    } else {
      controller.markTodoActive(index);
    }
  });

  todoText.innerText = todo.text;

  todoDeleteButton.innerText = 'Delete';
  todoDeleteButton.addEventListener('click', () => {
    controller.deleteTodoAtIndex(index);
  });

  todoItem.appendChild(todoCheckbox);
  todoItem.appendChild(todoText);
  todoItem.appendChild(todoDeleteButton);

  this.todosList.appendChild(todoItem);
});
}
}

class TodoFooterView {
constructor() {
this.activeTodosCount = document.querySelector('.footer p');
this.allButton = document.querySelector('.footer button:nth-child(2)');
this.activeButton = document.querySelector('.footer button:nth-child(3)');
this.completedButton = document.querySelector('.footer button:nth-child(4)');
this.clearButton = document.querySelector('.footer button:nth-child(5)');
}

render(todoList) {
const activeTodos = todoList.getActiveTodos();
this.activeTodosCount.innerText = `${activeTodos.length} items left`;

this.allButton.classList.remove('active');
this.activeButton.classList.remove('active');
this.completedButton.classList.remove('active');

if (controller.viewState === 'all') {
  this.allButton.classList.add('active');
} else if (controller.viewState === 'active') {
  this.activeButton.classList.add('active');
} else if (controller.viewState === 'completed') {
  this.completedButton.classList.add('active');
}

if (todoList.getCompletedTodos().length > 0) {
  this.clearButton.style.display = 'block';
} else {
  this.clearButton.style.display = 'none';
}
}
}

// Controller
class TodoListController {
constructor(todoList, todoListView, todoFooterView) {
this.todoList = todoList;
this.todoListView = todoListView;
this.todoFooterView = todoFooterView;
this.viewState = 'all';
}

addTodo() {
const newTodoInput = document.querySelector('.header input');
const newTodoText = newTodoInput.value;
if (newTodoText.trim() !== '') {
    const newTodo = new Todo(newTodoText);
    this.todoList.addTodo(newTodo);
    newTodoInput.value = '';
    this.render();
  }
}

deleteTodoAtIndex(index) {
this.todoList.deleteTodoAtIndex(index);
this.render();
}

markTodoCompleted(index) {
this.todoList.markTodoAtIndexCompleted(index);
this.render();
}

markTodoActive(index) {
this.todoList.markTodoAtIndexActive(index);
this.render();
}

filterByState(state) {
this.viewState = state;
this.render();
}

clearCompleted() {
this.todoList.todos = this.todoList.getActiveTodos();
this.render();
}

render() {
if (this.viewState === 'all') {
this.todoListView.render(this.todoList);
} else if (this.viewState === 'active') {
const activeTodoList = new TodoList();
activeTodoList.todos = this.todoList.getActiveTodos();
this.todoListView.render(activeTodoList);
} else if (this.viewState === 'completed') {
const completedTodoList = new TodoList();
completedTodoList.todos = this.todoList.getCompletedTodos();
this.todoListView.render(completedTodoList);
}
this.todoFooterView.render(this.todoList);
}
}

// Initialize app
const todoList = new TodoList();
const todoListView = new TodoListView();
const todoFooterView =