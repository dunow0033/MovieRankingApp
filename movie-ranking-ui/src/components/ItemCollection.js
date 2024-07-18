import Item from './Item';

const ItemCollection = ({items, drag, imgArr}) => {
    return (
        <div className="items-not-ranked">
        {
        // (items.length > 0) ? items.map((item) => 
        // (item.ranking === 0) ? 
        //     <div className="unranked-cell">
        //         <img id={`item-${item.id}`} src={ imgArr.find(o => o.id === item.imageId)?.image }
        //             style={{ cursor: "pointer" }} draggable="true" onDragStart={drag}
        //         />
        //     </div> : null
        // ) : <div> Loading... </div>

            items.map((item) => (item.ranking === 0) ?
                <Item item={item} drag={drag} itemImgObj={imgArr.find(o => o.id === item.imageId)} />
                : null)
            }
        </div>
    )
}

export default ItemCollection;