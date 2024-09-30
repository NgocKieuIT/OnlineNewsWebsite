// lấy cái gom nhóm
var login = document.getElementsByClassName("login");
var register = document.getElementsByClassName("register");

// Ban đầu ẩn đăng ký 
register[0].style.display = 'none';

// Lấy các nút thay đổi
var switch_to_register = document.getElementById("switch_to_register");
var switch_to_login = document.getElementById("switch_to_login");

function noneblock(e) {
    login[0].style.display = 'none';
    register[0].style.display = 'none';

    if (e == switch_to_register) {
        register[0].style.display = 'block';
    } else if (e == switch_to_login) {
        login[0].style.display = 'block';
    } else {
        login[0].style.display = 'block';
    }
}

//Khi click để chuyển form đăng nhập
switch_to_login.addEventListener('click', function () {
    window.location.href = "SignInSignUp.aspx?name=DangNhap";

});

//Khi click để chuyển form đăng kí
switch_to_register.addEventListener('click', function () {
    window.location.href = "SignInSignUp.aspx?name=DangKy"
});

//Hàm gọi trang phù hợp
window.onload = function () {
    //Lấy Url hiện tại
    var URL = window.location.href;

    //Tạo một biểu thức chính quy để tìm kiếm tham số name trong URL:
    var regex = /[?&]name=(\w+)/;

    //Kiểm tra xem URL có chứa tham số name không:
    var match = URL.match(regex);

    //Nếu tham số name có giá trị là "DangKy", thì click vào phần tử switch_to_register:
    if (match) {
        if (match[1] == "DangKy") {
                noneblock(switch_to_register);
        } else {
            if (match[1] == "DangNhap") {
                noneblock(switch_to_login);
            }
        }
    }
}

/*// Điều kiện ràng buộc
var input = document.getElementsByTagName('input')
for (let i = 0; i < input.length; i++) {
    if (i != 10) {
        input[i].addEventListener("input", function () {
            let regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{5,}$/;
            //              chữ thường   chữ hoa    số        kí tự         kết hợp  độ dài 5->?
            let valid = regex.test(input[i].value);
            let pvalue = document.querySelectorAll("p." + input[i].className);

            if (valid) {
                pvalue[0].innerHTML = "";

            }
            else {
                pvalue[0].innerHTML = "Mật khẩu không hợp lệ (A-Z)(a-z)(0-9)(7 kt->)(!@#$%^&*())"
            }
        })
    }
}*/

// Hàm điều kiện cho form đăng kí
document.addEventListener('DOMContentLoaded', function () {
    const accountInput = document.getElementById('register_account');
    const emailInput = document.getElementById('register_email');
    const passwordInput = document.getElementById('register_password');
    const passwordMessage = document.querySelector('p.register_password');
    const xacnhan = document.getElementById('xacnhan');

    // Validate email
    function validateEmail(email) {
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return emailRegex.test(email);
    }

    // Validate password
    function validatePassword(password) {
        const passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
        //                        chữ thường     chữ hoa    số     kí tự đặc biệt       độ dài
        return passwordRegex.test(password);
    }

    // Add event listeners for inputs
    accountInput.addEventListener('input', function () {
        if (accountInput.value.trim() === '') {
            accountInput.setCustomValidity('Tên đăng nhập không được để trống');
        } else {
            accountInput.setCustomValidity('');
        }
    });

    emailInput.addEventListener('input', function () {
        if (!validateEmail(emailInput.value)) {
            emailInput.setCustomValidity('Email không hợp lệ');
        } else {
            emailInput.setCustomValidity('');
        }
    });

    passwordInput.addEventListener('input', function () {
        if (!validatePassword(passwordInput.value)) {
            passwordMessage.textContent = "Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt";
            passwordInput.setCustomValidity('Mật khẩu không hợp lệ');
        } else {
            passwordMessage.textContent = "";
            passwordInput.setCustomValidity('');
        }
    });


    //Điều kiện Mã xác nhận
    function validateMa(xacnhan) {
        const xacnhanRegex = /^[A-Z]{3}\d{2}$/;
        return xacnhanRegex.test(xacnhan);
    }
    xacnhan.addEventListener('input', function () {
        if (!validateMa(xacnhan.value)) {
            xacnhan.setCustomValidity('Mã xác nhận phải có 3 kí tự in hoa, 2 chữ số');
        } else {
            xacnhan.setCustomValidity('');
        }
    });
});


//hiện mật khẩu

function togglePassword() {
    var passwordInput = document.getElementById("login_password");
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    } else {
        passwordInput.type = "password";
    }
}