
// logical functions for adding and removing ids
function getGuidListFromLocalStorage() {
    const guidList = JSON.parse(localStorage.getItem('guidList')) || [];
    return guidList;
}

function saveGuidListToLocalStorage(guidList) {
    localStorage.setItem('guidList', JSON.stringify(guidList));
}
// Adding and Removing IDs Efficiently
function addGuidToList(guid) {
    const guidList = getGuidListFromLocalStorage();
    const index = guidList.indexOf(guid);
    if(index==-1)
    {
        guidList.push(guid);
        saveGuidListToLocalStorage(guidList);
    }
    
}
function removeGuidFromList(guid) {
    const guidList = getGuidListFromLocalStorage();
    const index = guidList.indexOf(guid);
    if (index !== -1) {
        guidList.splice(index, 1);
        saveGuidListToLocalStorage(guidList);
    }
}

//logic to auto select and deselect checkboxs from local storag ids 
function autoSelect(checkBoxes)
{
    //all selected item cound 
    const totalSelectedItems = getGuidListFromLocalStorage();
    const totalItemElement = document.getElementById('totalSelectedItems');
    totalItemElement.innerText=totalSelectedItems.length;
    const selectAllInput = document.getElementById('selectAllInput');
    let selectedAll = true;
    const gList = getGuidListFromLocalStorage();

    checkBoxes.forEach(element =>{
        const index = gList.indexOf(element.id);
        if(index!==-1)
        {
            element.checked=true;
        }
        else{
            element.checked = false;
            selectedAll=false;
        }
    })
    if(selectedAll){
        selectAllInput.checked=true;
    }else{
        selectAllInput.checked=false;
    }
}

//Handling Logic of select All
function selectAllInputFunc(checkBoxes)
{
    const selectAllInput = document.getElementById('selectAllInput');
    
    selectAllInput.addEventListener('change',function(event){
        if(event.target.checked){
            checkBoxes.forEach(element=>{
                addGuidToList(element.id);
            })
        }else{
            checkBoxes.forEach(element=>{
                removeGuidFromList(element.id);
            });
        }
        autoSelect(checkBoxes);
        controlSelectButton();
    })
}
const checkBoxes = document.querySelectorAll(".scheckbox");
//calling selectAll Input func
selectAllInputFunc(checkBoxes);
// calling Auto Select function for page initialization
autoSelect(checkBoxes);
//Event Listener for each item selection
checkBoxes.forEach(element => {
    element.addEventListener('change',function(event){
        if(event.target.checked)
        {
           addGuidToList(event.target.id);
        }
        else{
            removeGuidFromList(event.target.id);
        }
        autoSelect(checkBoxes);
        controlSelectButton();
    })
});
//Delete Button Event Listener

function controlSelectButton()
{
    const selectedDeleteButton = document.getElementById('selectedDeleteButton');
    const guidList = getGuidListFromLocalStorage();
    if(guidList.length==0)
    {
        selectedDeleteButton.classList.add('d-none');
    }
    else{
        selectedDeleteButton.classList.remove('d-none');
    }
}
controlSelectButton();
const selectedDeleteButton = document.getElementById('selectedDeleteButton');
selectedDeleteButton.addEventListener('click',()=>{
    deleteMultipleRecords();
})
function deleteMultipleRecords()
{
    // Fetch request to the DeleteMultipleRecords endpoint
    fetch('/api/DeleteMultiple/delete-multiple', {
        method: 'DELETE',
        headers: {
        'Content-Type': 'application/json',
        },
        body: localStorage.getItem('guidList'),
    })
        .then(response => {
        if (response.ok) {
            const emptyArr=[];
            console.log('Records deletion started successfully.');
            localStorage.setItem('guidList',JSON.stringify(emptyArr));
            controlSelectButton();
            //window.location.reload();
            var deletingModal = new bootstrap.Modal(document.getElementById('deleteResponseModal'), {
                keyboard: false
            });
            deletingModal.show();
            return response;
        }
        throw new Error('Network response was not ok.');
        })
        .then(data => {
        console.log('Response received:', data);
        })
        .catch(error => {
        console.error('Error:', error);
        });
}
