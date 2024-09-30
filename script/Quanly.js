// Open Popup Modal Add
let btnAddProduct = document.getElementById("btn-add-product");
btnAddProduct.addEventListener("click", () => {
    document.querySelectorAll(".add-product-e").forEach(item => {
        item.style.display = "block";
    })
    document.querySelectorAll(".edit-product-e").forEach(item => {
        item.style.display = "none";
    })
    document.querySelector(".add-product").classList.add("open");
});


// Close Popup Modal
let closePopup = document.querySelectorAll(".modal-close");
let modalPopup = document.querySelectorAll(".modal");

for (let i = 0; i < closePopup.length; i++) {
    closePopup[i].onclick = () => {
        modalPopup[i].classList.remove("open");
    };
}

//On change Image
function uploadImage(el) {
    let path = "../assest/img/" + el.value.split("\\")[2];
    document.querySelector(".upload-image-preview").setAttribute("src", path);
}

//Xóa báo
function Xoa(id) {
    if (confirm("Bạn có chắc chắn muốn xóa item này không?")) {
        window.location.href = '../aspx/XuLy.aspx?id=' + id;

    } else {
        window.location.href = '../aspx/QuanLy.aspx';
    }
}
//Sửa
function Sua() {
    document.querySelectorAll(".add-product-e").forEach(item => {
        item.style.display = "none";
    })
    document.querySelectorAll(".edit-product-e").forEach(item => {
        item.style.display = "block";
    })
    document.querySelector(".add-product").classList.add("open");
}
