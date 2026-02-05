variable "name" {
  description = "The name for the application"
  type        = string
}

variable "source_repo" {
  description = "The Git repository to clone"
  type        = string
}

variable "compose_path" {
  description = "The repo relative path to the compose file to deploy"
  type        = string
}
