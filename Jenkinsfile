pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        def msbuildPath = tool name: 'MSBuild', type: 'msbuild'
        bat "\"${msbuildPath}\" ./src/Cobweb.sln /p:Configuration=Release"
      }
    }
  }
}
