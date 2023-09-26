from geopy.geocoders import Nominatim

locator = Nominatim(user_agent="Geoloation")
# location = locator.geocode("กรุงเทพมหานคร, พระราม 1, ปทุมวัน")
# location = locator.geocode("สุราษฎร์ธานี, เลี่ยงเมือง, มะขามเตี้ย, เมืองสุราษฎร์ธานี")

# print(f"Latitude = {location.latitude}, Longitude = {location.longitude}")

def getLat(addr):
    location = locator.geocode(addr)

    return f"Latitude = {location.latitude}"

def getLon(addr):
    location = locator.geocode(addr)

    return f"Latitude = {location.longitude}"
