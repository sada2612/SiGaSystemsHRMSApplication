window.showDeleteConfirmation = function () {
    const tcs = new Promise((resolve, reject) => {
        Swal.fire({
            title: "Are you sure?",
            text: "You won't be able to revert this!",
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#1b6ec2",
            cancelButtonColor: "#d33",
            confirmButtonText: "Yes, delete it!"
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(true);
            } else {
                resolve(false);
            }
        });
    });

    return tcs;
};

window.showEditConfirmation = function () {
    const tcs = new Promise((resolve) => {
        Swal.fire({
            title: "Do you want to save the changes?",
            icon: "question",
            showDenyButton: true,
            showCancelButton: true,
            confirmButtonText: "Save",
            confirmButtonColor:"#1b6ec2",
            denyButtonText: `Don't save`
        }).then((result) => {
            if (result.isConfirmed) {
                resolve(true)
            } else if (result.isDenied) {
                Swal.fire("Product are not saved", "Warning!", "info");
                resolve(false)
            }
        });
    });

    return tcs;
};

window.SuccessAlert = function (Title) {
    const Toast = Swal.mixin({
        toast: true,
        position: "top-end",
        showConfirmButton: false,
        timer: 2000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.onmouseenter = Swal.stopTimer;
            toast.onmouseleave = Swal.resumeTimer;
        }
    });
    const tcs = new Promise((resolve) => {
        Toast.fire({
            icon: "success",
            title: Title
        }).then((data) => {
            if (data.dismiss) {
                resolve(true)
            }
        });
       
    });

    return tcs;
};


