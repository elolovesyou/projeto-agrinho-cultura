@import url('https://fonts.googleapis.com/css2?family=Chocolate+Classical+Sans&family=Rakkas&display=swap');

:root {
    --primary-color: #4CAF50; /* Verde mais vibrante */
    --secondary-color: #388E3C; /* Verde escuro */
    --text-color: #333333; /* Texto em um tom de cinza escuro */
    --background-color: #FAF3E0; /* Um tom mais suave e claro de fundo */
    --button-hover: #2C6B1F; /* Cor de fundo para o botão em hover */
    --font-body: "Chocolate Classical Sans", serif;
    --font-titulo: "Rakkas", serif;
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: var(--font-body);
}

body {
    background-color: var(--background-color);
    color: var(--text-color);
    line-height: 1.6;
    font-size: 16px;
    padding: 20px;
}

header {
    text-align: center;
    margin-bottom: 30px;
}

h1 {
    font-size: 2.5rem;
    color: var(--primary-color);
    font-family: var(--font-titulo);
}

nav ul {
    list-style: none;
    padding: 0;
}

nav ul li {
    display: inline-block;
    margin: 0 15px;
}

nav ul li a {
    text-decoration: none;
    color: var(--text-color);
    font-size: 1.1rem;
    font-weight: bold;
    text-transform: uppercase;
}

nav ul li a:hover {
    color: var(--primary-color);
}

h2, h3 {
    color: var(--primary-color);
}

h3 {
    margin-top: 25px;
    font-size: 1.8rem;
}

p {
    margin-top: 20px;
    font-size: 1rem;
    line-height: 1.8;
}

img {
    max-width: 90%;
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

footer {
    text-align: center;
    margin-top: 50px;
    padding: 20px;
    background-color: var(--secondary-color);
    color: white;
}

footer p {
    font-size: 1rem;
}

/* Responsividade */
@media (max-width: 768px) {
    body {
        padding: 10px;
    }

    .conteudo {
        width: 90%;
        margin: 0 auto;
    }

    nav ul {
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    nav ul li {
        margin: 10px 0;
    }

    img {
        max-width: 100%;
    }
}
