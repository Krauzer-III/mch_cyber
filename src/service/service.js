import axios from 'axios'

class Service {
    constructor(url) {
        this.url = url
    }
    
    async getData() {
        const config = {
            headers: {
                "Content-Type":"application/x-www-form-urlencoded",
                "Access-Control-Allow-Origin": "https://www.mos.ru/api/newsfeed/v4/frontend/json/afisha",
                "Access-Control-Allow-Methods": '*'
            },
            mode: "cors",
            crossdomain: 'true',

          
        }
        const {data} = await axios.get(this.url, config)
        
        return data
    }
}

const service = new Service('https://www.mos.ru/api/newsfeed/v4/frontend/json/afisha')

export default service