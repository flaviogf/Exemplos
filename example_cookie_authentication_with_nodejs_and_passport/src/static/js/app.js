const inputs = document.querySelectorAll('.form__input')

function onFocus() {
  this.parentNode.classList.add('form__group--focus')
}

function onBlur() {
  if (this.value) return
  this.parentNode.classList.remove('form__group--focus')
}

inputs.forEach((it) => it.addEventListener('focus', onFocus))
inputs.forEach((it) => it.addEventListener('blur', onBlur))
