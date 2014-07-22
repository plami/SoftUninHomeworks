var player = 1;

function clickBtn(btn) {
    if (document.getElementById(btn).value === "") {
        if (player === 1) {
            document.getElementById(btn).value = "X";
            player += 1;
        }
        else {
            document.getElementById(btn).value = "O";
            player -= 1;
        }

        if ((btn1.value !== "") && (btn1.value === btn2.value) && (btn2.value === btn3.value)) {
            winner(1, 2, 3, btn1.value);
        }
        else if ((btn4.value != "") && (btn4.value === btn5.value) && (btn5.value === btn6.value)) {
            winner(4, 5, 6, btn4.value);
        }
        else if ((btn7.value != "") && (btn7.value === btn8.value) && (btn8.value === btn9.value)) {
            winner(7, 8, 9, btn7.value);
        }
        else if ((btn1.value != "") && (btn1.value === btn4.value) && (btn4.value === btn7.value)) {
            winner(1, 4, 7, btn1.value);
        }
        else if ((btn2.value != "") && (btn2.value === btn5.value) && (btn5.value === btn8.value)) {
            winner(2, 5, 8, btn2.value);
        }
        else if ((btn3.value != "") && (btn3.value === btn6.value) && (btn6.value === btn9.value)) {
            winner(3, 6, 9, btn3.value);
        }
        else if ((btn1.value != "") && (btn1.value === btn5.value) && (btn5.value === btn9.value)) {
            winner(1, 5, 9, btn1.value);
        }
        else if ((btn3.value != "") && (btn3.value === btn5.value) && (btn5.value === btn7.value)) {
            winner(3, 5, 7, btn3.value);
        }
    }

    function winner(firstButton, secondButton, thirdButton, winner) {
        var calc1 = 'btn' + (firstButton * 1);
        var calc2 = 'btn' + (secondButton * 1);
        var calc3 = 'btn' + (thirdButton * 1);

        document.getElementById(calc1).style.color = '#05d108';
        document.getElementById(calc2).style.color = '#05d108';
        document.getElementById(calc3).style.color = '#05d108';
        alert(winner + ' Win !');
    }

    //else if ((btn7.value === btn8.value) && (btn8.value === btn9.value)) {
    //    alert('win');
    //}
}