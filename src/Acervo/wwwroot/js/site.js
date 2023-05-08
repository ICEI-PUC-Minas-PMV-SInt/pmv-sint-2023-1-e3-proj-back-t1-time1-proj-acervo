const home = document.querySelector('.home');
const catalogo = document.querySelector('.catalogo');
const login = document.querySelector('.login');

// Adiciona um listener de clique a cada elemento
home.addEventListener('click', () => {
    document.querySelector('.home').classList.add('active'); // Adiciona a classe active ao elemento home
    catalogo.classList.remove('active'); // Remove a classe active do elemento catalogo
    login.classList.remove('active'); // Remove a classe active do elemento login
});

catalogo.addEventListener('click', () => {
    home.classList.remove('active'); // Remove a classe active do elemento home
    document.querySelector('.catalogo').classList.add('active'); // Adiciona a classe active ao elemento catalogo
    login.classList.remove('active'); // Remove a classe active do elemento login
});

login.addEventListener('click', () => {
    home.classList.remove('active'); // Remove a classe active do elemento home
    catalogo.classList.remove('active'); // Remove a classe active do elemento catalogo
    document.querySelector('.login').classList.add('active'); // Adiciona a classe active ao elemento login
});