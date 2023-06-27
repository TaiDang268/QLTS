import axios from "axios";
const actions = {
  // Call API lấy dữ liệu table
  async fetchData({ commit }) {
    try {
      const response = await axios.get("https://localhost:7237/api/Assets");
      const data = response.data;
      commit("setTableData", data); // Gọi mutation để cập nhật state
    } catch (error) {
      console.error("Error fetching data:", error);
    }
  },

  // push id cuả các hàng được chọn vào mảng
  addToDelete({ commit, state }, id) {
    if (state.listIdDelete.includes(id)) {
      commit("removeIdFromDelete", id);
    } else {
      commit("pushIdToDelete", id);
    }
  },

  deleteTableRow({ commit, state }) {
    const { tableData, listIdDelete } = state;
    const updatedTableData = tableData.filter(
      (item) => !listIdDelete.includes(item.id)
    );
    commit("setTableData", updatedTableData);
    commit("clearIdDelete");
  },
};
export default actions;
// Call API lấy dữ liệu danh sách phòng ban
// async fetchDepartment({ commit }) {
//   try {
//     const response = await axios.get("http://localhost:3000/departmentIds");
//     const data = response.data;
//     commit("setDepartmentData", data); // Gọi mutation để cập nhật state
//   } catch (error) {
//     console.error("Error fetching data:", error);
//   }
// },
// Call API lấy danh sách loại tài sản
// async fetchTypeProperty({ commit }) {
//   try {
//     const response = await axios.get("http://localhost:3000/typesProperty");
//     const data = response.data;
//     commit("setTypeData", data); // Gọi mutation để cập nhật state
//   } catch (error) {
//     console.error("Error fetching data:", error);
//   }
// },
