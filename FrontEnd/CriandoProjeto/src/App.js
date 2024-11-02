import React, { useState, useEffect } from 'react';

const App = () => {

    const [usuario, setUsuario] = useState("");
    const [count, setCount] = useState("");
    const [usuarios, setUsuarios] = useState(
        ["Pablo", "Pedro", "Paulo"]
    );

    const handleAddUser = () => {
        setUsuarios([...usuarios, usuario]);
        setUsuario("");
    }

    useEffect(() => {
        setCount(usuarios.length);
    }, [usuarios]);

    return (
        <div className="App">
            <h1>Usuários</h1>
            <h3>Total de Usuários: {count}</h3>

            <div>
                <input type="text" value={usuario} onChange={(event) => setUsuario(event.target.value)}/>
                <button onClick={handleAddUser}>Adicionar</button>
            </div>

            <ul>
                {usuarios.map((usuario, index) => (
                    <li key={index}>{usuario}</li>
                ))}
            </ul>
        </div>
    )
}

export default App;