<template>
  <div class="popup">
    <div class="popup-header">
      <p class="popup-title">{{ popupTitle }}</p>
      <div class="popup-close-icon" @click="handleOnClickCloseBtn"></div>
    </div>
    <div class="popup-content">
      <div class="item1">
        <p>
          Mã tài sản
          <span class="red-star">*</span>
        </p>
        <input type="text" v-model="id" ref="idInput" :tabindex="tabindex" />
        <p v-if="isIdValid" class="error-message">
          Mã tài sản không được để trống
        </p>
      </div>
      <div class="item2">
        <p>
          Tên tài sản
          <span class="red-star">*</span>
        </p>
        <input v-model="name" ref="nameInput" :tabindex="tabindex + 1" />
        <p v-if="isNameValid" class="error-message">
          Tên tài sản không được để trống
        </p>
      </div>
      <div class="item3">
        <p>
          Mã bộ phận sử dụng
          <span class="red-star">*</span>
        </p>
        <MISACombobox
          class="combobox-custom"
          :items="listDepartmentID"
          v-model:value="inputDepartmentID"
          :placeholder="'Chọn mã bộ phận sử dụng'"
          ref="departmentIdInput"
          :tabindex="tabindex + 2"
        />
        <p v-if="isDepartmentIdValid" class="error-message">
          Mã bộ phận sử dụng không được để trống
        </p>
      </div>
      <div class="item4">
        <p>Tên bộ phận sử dụng</p>
        <input v-model="department" ref="departmentInput" />
      </div>
      <div class="item5">
        <p>
          Mã loại tài sản
          <span class="red-star">*</span>
        </p>
        <MISACombobox
          class="combobox-custom"
          :items="listTypePropertyID"
          v-model:value="inputTypePropertyID"
          :placeholder="'Chọn mã loại tài sản'"
          ref="typePropertyIdInput"
          :tabindex="tabindex + 3"
        />
        <p v-if="isTypePropertyIdValid" class="error-message">
          Mã loại tài sản không được để trống
        </p>
      </div>
      <div class="item6">
        <p>Tên loại tài sản</p>
        <input v-model="type" ref="typeInput" />
      </div>
      <div class="item7">
        <p>
          Số lượng
          <span class="red-star">*</span>
        </p>
        <MISAInputNumber
          v-model="quantity"
          ref="quantityInput"
          :tabindex="tabindex + 4"
        />
        <p v-if="isQuantityValid" class="error-message">
          Số lượng không được để trống
        </p>
      </div>
      <div class="item8">
        <p>
          Nguyên giá
          <span class="red-star">*</span>
        </p>
        <input v-model="price" :tabindex="tabindex + 5" />
        <p v-if="isPriceValid" class="error-message">
          Nguyên giá không được để trống
        </p>
      </div>
      <div class="item9">
        <p>
          Số năm sử dụng
          <span class="red-star">*</span>
        </p>
        <input ref="yearsInUseInput" :tabindex="tabindex + 6" />
        <p v-if="isYearsInUseValid" class="error-message">
          Số năm sử dụng không được để trống
        </p>
      </div>
      <div class="item10">
        <p>
          Tỷ lệ hao mòn
          <span class="red-star">*</span>
        </p>
        <MISAInputNumber
          decimalAllowed="true"
          :step="1"
          ref="depreciationRateInput"
        />
        <p v-if="isDepreciationRateValid" class="error-message">
          Tỷ lệ hao mòn không được để trống
        </p>
      </div>
      <div class="item11">
        <p>
          Giá trị hao mòn năm
          <span class="red-star">*</span>
        </p>
        <input v-model="price__used" ref="depreciationValueInput" />
        <p v-if="isDepreciationValueValid" class="error-message">
          Giá trị hao mòn năm không được để trống
        </p>
      </div>
      <div class="item12">
        <p>Năm theo dõi</p>
        <input type="text" />
      </div>
      <div class="item13">
        <p>
          Ngày mua
          <span class="red-star">*</span>
        </p>
        <MISADatePicker type="date" isRequired="true" />
      </div>
      <div class="item14">
        <p>
          Ngày bắt đầu sử dụng
          <span class="red-star">*</span>
        </p>
        <MISADatePicker type="date" isRequired="true" />
      </div>
    </div>
    <div class="popup-footer">
      <MISAButton class="popup-cancel-btn" @click="handleClickCancelBtn">
        Hủy
      </MISAButton>
      <MISAButton class="popup-save-btn" @click="handleClickSaveBtn">
        Lưu
      </MISAButton>
    </div>
  </div>
  <div class="overlay"></div>
</template>
<script>
import validate from "../../validate";
export default {
  props: {
    tabindex: {
      type: Number,
      required: false,
      default: 1,
    },
  },
  data() {
    return {
      listDepartmentID: [
        { name: "DepartmentID1" },
        { name: "DepartmentID2" },
        { name: "DepartmentID3" },
      ], //danh sách mã bộ phận sử dụng
      listTypePropertyID: [
        { name: "TypePropertyID1" },
        { name: "TypePropertyID2" },
        { name: "TypePropertyID3" },
      ], //danh sách mã loại tài sản
      inputDepartmentID: "",
      inputTypePropertyID: "",
      id: "",
      isIdValid: false,
      name: "",
      isNameValid: false,
      quantity: 0,
      isQuantityValid: false,
      yearsInUse: "",
      isYearsInUseValid: false,
      depreciationRate: 0,
      isDepartmentIdValid: false,
      depreciationValue: "",
      isDepreciationRateValid: false,
    };
  },
  computed: {
    price: {
      get() {
        return this.row.price || "";
      },
      set(value) {
        this.row.price = value;
      },
    },
    /*
    Lấy state ra để load lên popup
    DVTAI 04/06/2023
    */
    row() {
      return this.$store.state.editedRow;
    },

    /*
    Lấy state popupTitle ra để load title lên popup
    DVTAI 08/06/2023
    */
    popupTitle() {
      return this.$store.state.popupTitle;
    },
  },
  watch: {
    price(newValue) {
      this.row.price = validate.formatMoney(newValue);
    },
  },
  methods: {
    //handle click savebtn
    handleClickSaveBtn() {
      this.isIdValid = this.id === "";
      this.isNameValid = this.name === "";
      this.isDepartmentIdValid = this.name === "";

      this.isQuantityValid = this.name === "";

      this.isYearsInUseValid = this.name === "";

      // if (this.isIdValid) {
      //   this.$refs.idInput.focus();
      // } else {
      //   if (this.isNameValid) {
      //     this.$refs.nameInput.focus();
      //   } else {
      //     console.log("abc");
      //   }
      // }
    },
    /*
    Xử lý onClick vào button X của popup
    DVTAI 04/06/2023
    */
    handleOnClickCloseBtn() {
      this.$store.commit("hidePopup");
      this.$store.commit("setPopupTitleNull");
    },
  },
};
</script>
<style scoped>
@import url(../../css/base/MISAPopup.css);
.error-message {
  font-size: 12px;
  color: red;
  margin-top: 5px;
}
</style>
