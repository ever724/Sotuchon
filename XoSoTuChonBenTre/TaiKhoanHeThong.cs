//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XoSoTuChonBenTre
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoanHeThong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoanHeThong()
        {
            this.PhanQuyens = new HashSet<PhanQuyen>();
            this.PhieuDuThuongs = new HashSet<PhieuDuThuong>();
            this.TaiKhoanHeThong1 = new HashSet<TaiKhoanHeThong>();
            this.Games = new HashSet<Games>();
            this.NapTien = new HashSet<NapTien>();
            this.NapTien1 = new HashSet<NapTien>();
            this.RutTien = new HashSet<RutTien>();
            this.RutTien1 = new HashSet<RutTien>();
            this.TraThuong = new HashSet<TraThuong>();
        }
    
        public int IDTaiKhoan { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string LevelCode { get; set; }
        public Nullable<bool> LaQuanLy { get; set; }
        public string HoTen { get; set; }
        public string ChietKhau { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string SoTaiKhoan { get; set; }
        public string NganHang { get; set; }
        public Nullable<bool> KichHoat { get; set; }
        public Nullable<double> ViTien { get; set; }
        public Nullable<System.DateTime> NgayDangKy { get; set; }
        public string MaTaiKhoan { get; set; }
        public Nullable<int> IDDaiLy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanQuyen> PhanQuyens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDuThuong> PhieuDuThuongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanHeThong> TaiKhoanHeThong1 { get; set; }
        public virtual TaiKhoanHeThong TaiKhoanHeThong2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Games> Games { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NapTien> NapTien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NapTien> NapTien1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RutTien> RutTien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RutTien> RutTien1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraThuong> TraThuong { get; set; }
    }
}
