import React, { useState } from 'react'
import axios from 'axios'

export default function App() {
  const [title, setTitle] = useState('')

  return (
    <div style={{ padding: 20 }}>
      <input value={title} onChange={e => setTitle(e.target.value)} />
      <button onClick={() => axios.post('/api/todos', { title })}>Create</button>
    </div>
  )
}
