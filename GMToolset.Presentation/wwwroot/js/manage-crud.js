﻿const clickables = Array.from(document.getElementsByClassName('manage-click'));
let currentObject;
let fieldsCopy;
let enableFlag = true;

clickables.forEach(clickable => {   
    clickable.addEventListener('click', selectTag );
});

function selectTag(evt) {
    if (!enableFlag) {
        enableFlag = true;
    }
    else if (currentObject == null && enableFlag) {
        enableEdit(evt.currentTarget);
    }
    else if (currentObject.dataset.id == evt.currentTarget.dataset.id) {
        evt = null;
        disbleEdit();
    }
}

function enableEdit(obj) {
    currentObject = obj;
    currentObject.classList.add('hover-background');

    let actionBox = currentObject.getElementsByClassName('manage-action-box')[0];

    let editButton = actionBox.appendChild(DOMGenerator.Button(['btn-success'], '<i class="fa-solid fa-check"></i>'));
    editButton.addEventListener('click', editEntry);

    let clearButton = actionBox.appendChild(DOMGenerator.Button(['btn-warning'], '<i class="fa-solid fa-xmark"></i>'));
    clearButton.addEventListener('click', selectTag);
    clearButton.setAttribute('data-id', currentObject.dataset.id);

    let removeButton = actionBox.appendChild(DOMGenerator.Button(['btn-danger'], '<i class="fa-solid fa-trash-can"></i>'));
    removeButton.addEventListener('click', removeEntry);

    let fields = Array.from(currentObject.getElementsByClassName('manage-field'));
    fieldsCopy = [];
    fields.forEach(field => {
        fieldsCopy.push(field.innerHTML);
        let contents = field.innerHTML;
        field.innerHTML = '';
        field.appendChild(DOMGenerator.Input([], 'text', contents));
    });

    currentObject.removeEventListener('click', selectTag);
}

function disbleEdit(evt) {
    currentObject.getElementsByClassName('manage-action-box')[0].innerHTML = '';
    currentObject.classList.remove('hover-background');

    let inputFields = Array.from(currentObject.getElementsByTagName('input'));
    for (let i = 0; i < inputFields.length; i++) {
        inputFields[i].parentElement.innerHTML = fieldsCopy[i];
    }

    enableFlag = false;
    currentObject.addEventListener('click', selectTag);
    currentObject = null;
    fields = null;
}

function removeEntry() {
    let deleteActionName = document.getElementById('manage-delete').value;

    fetch(url = `${deleteActionName}`, {
        method: 'delete',
        headers: {
            'content-type': 'application/json',
            'accept': 'application/json',
            'RequestVerificationToken': document.getElementById('manage-token').getElementsByTagName('input')[0].value
        },
        body: JSON.stringify(currentObject.dataset.id)
    }).then((response) => {
        if (response.ok) {
            window.location.reload();
        } else {
            console.error(response.status);
        }
    });
}

function editEntry() {
    let patchtActionName = document.getElementById('manage-patch').value;
    let fieldArray = Array.from(currentObject.getElementsByClassName('manage-field'));
    let editObject = {};
    fieldArray.forEach(field => {
        editObject[field.dataset.fieldName] = field.getElementsByTagName('input')[0].value;
    });
    editObject['Id'] = currentObject.dataset.id;

    fetch(url = `${patchtActionName}`, {
        method: 'patch',
        headers: {
            'content-type': 'application/json',
            'accept': 'application/json',
            'RequestVerificationToken': document.getElementById('manage-token').getElementsByTagName('input')[0].value
        },
        body: JSON.stringify(editObject)
    }).then((response) => {
        if (response.ok) {
            window.location.reload();
        } else {
            console.error(response.patch);
        }
    });
}