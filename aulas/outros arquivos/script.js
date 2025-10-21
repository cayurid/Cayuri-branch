/*function calcular(operacao) {
            var op1 = parseFloat(document.getElementById('operador1').value);
            var op2 = parseFloat(document.getElementById('operador2').value);
            var resultado = '';
            if (isNaN(op1) || isNaN(op2)) {
                resultado = 'Valores inválidos';
            } else {
                switch (operacao) {
                    case '+': resultado = op1 + op2; break;
                    case '-': resultado = op1 - op2; break;
                    case '/': resultado = op2 !== 0 ? op1 / op2 : 'Divisão por zero'; break;
                    case '*': resultado = op1 * op2; break;
                }
            }
            document.getElementById('resultado').value = resultado;
        }
            */
 function calcular(operacao) {
            var op1 = parseFloat(document.getElementById('operador1').value);
            var op2 = parseFloat(document.getElementById('operador2').value);
            var resultado = '';
            if (isNaN(op1) || isNaN(op2)) {
                resultado = 'Valores inválidos';
            } else {
                switch (operacao) {
                    case '+': resultado = op1 + op2; break;
                    case '-': resultado = op1 - op2; break;
                    case '/': resultado = op2 !== 0 ? op1 / op2 : 'Divisão por zero'; break;
                    case '*': resultado = op1 * op2; break;
                    case '%': resultado = op1 % op2; break;
                    case '^': resultado = Math.pow(op1, op2); break;
                    case 'sqrt': resultado = Math.sqrt(op1,op2); break;

                }
            }
            document.getElementById('resultado').value = resultado;
        }
