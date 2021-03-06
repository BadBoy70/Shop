import React,{Component} from 'react';
import { Header, Icon, Image, List } from 'semantic-ui-react'
import './App.css';
import axios from 'axios';

class App extends Component {
  state={
    values:[]
  }
componentDidMount(){

  axios.get('http://localhost:5000/api/values')
      .then((response) =>{
        console.log(response);
        this.setState({
          values:response.data
        })
      })
}
 render(){
  return (
    <div >
       <Header as='h2' icon textAlign='center'>
          <Icon name='users' circular />
          <Header.Content>Reactivits</Header.Content>
        </Header>
        <List>
           {
              this.state.values.map((value:any)=>
              <List.Item key={value.id}>{value.name}</List.Item>
                
              )
            }
        </List>
    </div>
  );
 }
}

export default App;
