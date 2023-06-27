const mutations = {
  // ẩn,hiển thị popup
  showPopup(state) {
    state.isPopupVisible = true;
  },
  hidePopup(state) {
    state.isPopupVisible = false;
  },
  // set giá trị cho popupTitle khi đóng mở popup
  setPopupTitleAdd(state) {
    state.popupTitle = "Thêm tài sản ";
  },
  setPopupTitleNull(state) {
    state.popupTitle = "";
  },
  setPopupTitleEdit(state) {
    state.popupTitle = "Sửa tài sản ";
  },

  // push các rowId được chọn vào listIdDelete
  pushIdToDelete(state, id) {
    state.listIdDelete.push(id);
  },
  // remove rowId khi được ấn lần 2
  removeIdFromDelete(state, id) {
    state.listIdDelete = state.listIdDelete.filter((itemId) => itemId !== id);
  },
  // delete 1 hoặc nhiều hàng
  handleDeleteItems(state) {
    state.listIdDelete.forEach((id) => {
      state.tableData = state.tableData.filter((item) => item.id !== id);
    });
  },
  clearIdDelete(state) {
    state.listIdDelete = [];
  },
  // editRow
  setEditedRow(state, row) {
    state.editedRow = row;
  },
  resetPopupData(state) {
    state.editedRow = null;
  },
  clearEditedRow(state) {
    state.editedRow = null;
  },
  // cập nhập data cho table
  setTableData(state, data) {
    state.tableData = data;
  },
};
export default mutations;
