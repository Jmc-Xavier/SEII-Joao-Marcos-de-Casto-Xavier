var valor;
var resutado;
function botao(num){
 valor = document.calc.visor.value += num;
}
function reseta() {
    document.calc.visor.value = '';
}
function calcula(){
    resutado = eval(valor);
    document.calc.visor.value = resultado.toLocaleString('pt-');
}