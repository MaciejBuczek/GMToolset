class DOMGenerator {
    static Button(classesArray, content) {
        let button = document.createElement('button');
        button.classList.add('btn');
        classesArray.forEach(c => button.classList.add(c));
        button.innerHTML = content;
        return button;
    }

    static Input(classesArray, type, content) {
        let input = document.createElement('input');
        input.type = type;
        input.value = content;
        input.classList.add('form-control');
        classesArray.forEach(c => input.classList.add(c));
        return input;
    }
}