select distinct brand from CloudApplications ca
inner join Vendors v
on ca.Vendor_VendorID = v.VendorID
left join VendorLogos vl
on v.VendorLogo_VendorLogoID = vl.VendorLogoID
where vl.Logo is null

AppShore
Batchbook
Brightpearl
ClickMeeting
Fuze Box
HARVEST
intuit
OmniJoin
Pipeline Deals
Planet Soho
salesboom
SuperOffice
WORKetc
