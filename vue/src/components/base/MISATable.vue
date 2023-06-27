<template>
  <div class="table-container" @contextmenu.prevent>
    <div class="table">
      <table>
        <thead>
          <tr>
            <th
              style="width: 40px"
              class="table-text-align--center"
              type="checkbox"
            >
              <div class="icon-box"></div>
            </th>
            <th
              class="table-text-align--center"
              type="number"
              style="padding-right: 20px; width: 70px"
            >
              STT
            </th>
            <th class="table-text-align--left" style="width: 140px">
              Mã tài sản
            </th>
            <th style="width: 140px" class="table-text-align--left">
              Tên tài sản
            </th>
            <th style="width: 190px" class="table-text-align--left">
              Loại tài sản
            </th>
            <th style="width: 180px" class="table-text-align--left">
              Bộ phận sử dụng
            </th>
            <th style="width: 90px" class="table-text-align--right">
              Số lượng
            </th>
            <th style="width: 130px" class="table-text-align--right">
              Nguyên giá
            </th>
            <th
              style="width: 140px"
              class="table-text-align--right"
              title="HM/KH lũy kế"
            >
              HM/KH lũy kế
            </th>
            <th style="width: 140px" class="table-text-align--right">
              Giá trị còn lại
            </th>
            <th style="width: 120px" class="table-text-align--center">
              Chức năng
            </th>
          </tr>
        </thead>
        <tbody>
          <MISARow
            v-for="(item, index) in dataList"
            :item="item"
            :key="item.assetId"
            :stt="index + 1"
            @removeItemSelectList="removeItemSelectList(item, index)"
            @addItemSelectList="addItemSelectList(item, index)"
          />
          <div></div>
        </tbody>
        <tfoot>
          <tr>
            <td colspan="6">
              <div class="pagination-container">
                <p style="font-family: RobotoRegular">
                  Tổng số: <span style="font-family: RobotoBold">200</span> bản
                  ghi
                </p>
                <el-select
                  v-model="valuePerPage"
                  class="m-2 select-per-page"
                  placeholder=""
                >
                  <el-option
                    v-for="item in optionsPerPage"
                    :key="item.value"
                    :label="item.label"
                    :value="item.value"
                  />
                </el-select>
                <MISAPagination style="margin-left: 20px" />
              </div>
            </td>
            <td class="table-text-align--right">13</td>
            <td class="table-text-align--right">249.000.000</td>
            <td class="table-text-align--right">19.894.000</td>
            <td class="table-text-align--right">194.106.000</td>
            <td class="table-text-align--center"></td>
          </tr>
        </tfoot>
      </table>
    </div>
  </div>
</template>
<script>
import axios from "axios";

export default {
  data() {
    return {
      valuePerPage: 20,
      optionsPerPage: [
        {
          value: "Option1",
          label: "20",
        },
        {
          value: "Option2",
          label: "30",
        },
        {
          value: "Option3",
          label: "50",
        },
      ],
      dataList: [], // dữ liệu table
      selectList: [], // danh sách tài sản được chọn
    };
  },
  created() {
    this.getData();
    // this.emitter.on("deleteItem", this.deleteItem);
  },
  methods: {
    // deleteItem() {
    //   this.selectList = [];
    // },
    //thêm item được chọn vào mảng selectList
    addItemSelectList(item) {
      this.selectList.push(item);
    },
    removeItemSelectList(item) {
      const index = this.selectList.indexOf(item);
      if (index > -1) {
        this.selectList.splice(index, 1);
      }
    },
    // gọi api lấy dữ liệu table
    async getData() {
      try {
        const response = await axios.get("https://localhost:7237/api/Assets");
        this.dataList = response.data;
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    },
  },
};
</script>
<style scoped>
@import url(../../css/base/MISATable.css);
</style>
