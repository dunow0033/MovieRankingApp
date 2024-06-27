import React, { useState, useEffect } from 'react';
import MovieImageArr from "./MovieImages.js";

const RankItems = () => {
    const [items, setItems] = useState([]);
    const dataType = 1;

    useEffect(() => {
        fetch("http://localhost:5160/ItemModels").then((results) => {
            return results.json();
        })
        .then(data => {
            setItems(data);
        })
    }, [])

    return (
        <main>
            {
                (items.length > 0) ? items.map((item) => 
                
                <h3>{item.title}</h3>
                
                ) : <div> Loading... </div>
            }
        </main>
    )
}

export default RankItems;